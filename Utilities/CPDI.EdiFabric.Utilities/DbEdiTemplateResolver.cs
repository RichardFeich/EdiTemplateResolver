using System.Collections.Concurrent;
using System.Data;
using System.Reflection;
using System.Runtime.Loader;
using CPDI.EdiFabric.Utilities.Infrastructure;
using CPDI.EdiFabric.Utilities.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Serilog;

namespace CPDI.EdiFabric.Utilities
{
    public sealed class DbEdiTemplateResolver : IEdiTemplateResolver
    {
        private readonly string _conn;
        private readonly ConcurrentDictionary<string, Type> _cache = new(StringComparer.Ordinal);
        private readonly ConcurrentDictionary<string, TypeInfo> _cacheTypeInfo = new(StringComparer.Ordinal);

        public DbEdiTemplateResolver(string connectionString) => _conn = connectionString;

        //Public API: resolve to a TypeInfo
        public TypeInfo ResolveTypeInfo(string partnerId, string versionRaw, string st01)
        {
            var ver = NormalizeVersion(versionRaw);
            var key = $"{NormalizePartner(partnerId)}|{ver}:{st01}";

            return _cacheTypeInfo.GetOrAdd(key, _ => LoadTemplateInfoFromDb(partnerId, ver, st01));
        }

        //Public API: resolve to a Type
        public Type Resolve(string partnerId, string versionRaw, string st01)
        {
            var ver = NormalizeVersion(versionRaw);
            var key = $"{NormalizePartner(partnerId)}|{ver}:{st01}";

            return _cache.GetOrAdd(key, _ => LoadTemplateFromDb(partnerId, ver, st01));
        }

        private TypeInfo LoadTemplateInfoFromDb(string partnerId, string ver, string st01)
        {
            var template = LoadTemplateFromDb(partnerId, ver, st01);
            if (template is not null)
                return template.GetTypeInfo();

            throw new InvalidOperationException("No usable template could be loaded");
        }

        // --- helper does all DB + fallback work and returns a Type ---
        private Type LoadTemplateFromDb(string partnerId, string ver, string st01)
        {
            var partnerKey = NormalizePartner(partnerId);
            var now = DateTime.UtcNow;

            using IDbConnection db = new SqlConnection(_conn);

            // 1) Resolve partnerKey via alias table (optional)
            var pk = db.QueryFirstOrDefault<string>(
                         "SELECT TOP 1 PartnerKey FROM edi.EdiPartnerAlias WHERE RawId = @raw ORDER BY Id",
                         new { raw = partnerKey })
                     ?? partnerKey;

            // 2) Partner-specific (or default) mapping for exact version & ST
            var rows = db.Query<TemplateRow>(@"
                SELECT TOP 50 *
                FROM edi.EdiTemplateMapping
                WHERE IsEnabled = 1
                  AND PartnerKey IN (@pk, '*')
                  AND VersionNorm = @ver
                  AND St01 = @st
                  AND (EffectiveFromUtc IS NULL OR EffectiveFromUtc <= @now)
                  AND (EffectiveToUtc   IS NULL OR EffectiveToUtc   >= @now)
                ORDER BY CASE WHEN PartnerKey=@pk THEN 0 ELSE 1 END, Priority ASC",
                    new { pk, ver, st = st01, now })
                .ToList();

            if (rows.Count == 0)
            {
                // 3) Graceful fallback: same ST in defaults, nearest lower version then highest
                rows = db.Query<TemplateRow>(@"
                    SELECT *
                    FROM edi.EdiTemplateMapping
                    WHERE IsEnabled = 1
                      AND PartnerKey = '*'
                      AND St01 = @st
                    ORDER BY VersionNorm ASC, Priority ASC",
                        new { st = st01 })
                    .ToList();
            }

            TemplateRow? chosenRow = null;
            var loader = new TemplateLoader(new SerilogAdapter(Log.Logger));
            foreach (var row in rows)
            {
                if (loader.TryLoadTemplate(row, out var desc))  // your assembly/type load logic
                {
                    chosenRow = row;
                    break;
                }

                if (row.IsStrict)
                {
                    throw new InvalidOperationException(
                        $"Strict template {row.TypeFullName} for partner {row.PartnerKey} failed to load."
                    );
                }
            }

            if (chosenRow is null)
            {
                throw new InvalidOperationException("No usable template found.");
            }

            return LoadType(chosenRow);
        }

        private static Type LoadType(TemplateRow row)
        {
            if (row is null) throw new ArgumentNullException(nameof(row));
            if (string.IsNullOrWhiteSpace(row.TypeFullName))
                throw new ArgumentException("TypeFullName is required.", nameof(row));

            // 1) If TypeFullName is assembly-qualified, this may just work.
            // (e.g., "Namespace.TS850, EdiFabric.Templates.X12004010")
            var direct = Type.GetType(row.TypeFullName, throwOnError: false, ignoreCase: false);
            if (direct is not null)
                return ValidateTemplateType(direct);

            Assembly? asm = null;

            // 2) Resolve by AssemblyName (preferred before path)
            if (!string.IsNullOrWhiteSpace(row.AssemblyName))
            {
                var an = new AssemblyName(row.AssemblyName);

                // a) Already loaded?
                asm = AppDomain.CurrentDomain
                               .GetAssemblies()
                               .FirstOrDefault(a =>
                                   string.Equals(a.GetName().Name, an.Name, StringComparison.Ordinal));

                // b) If not loaded, try to load by name (lets the runtime find it via deps/probing)
                if (asm is null)
                {
                    try { asm = Assembly.Load(an); }
                    catch (FileNotFoundException) { /* keep trying via path */ }
                    catch (FileLoadException) { /* keep trying via path */ }
                    catch (BadImageFormatException) { /* keep trying via path */ }
                }
            }

            // 3) Fallback to explicit path (best for plugin-like deployments)
            if (asm is null && !string.IsNullOrWhiteSpace(row.AssemblyPath))
            {
                var fullPath = Path.GetFullPath(row.AssemblyPath);
                if (!File.Exists(fullPath))
                    throw new FileNotFoundException($"AssemblyPath not found: {fullPath}", fullPath);

                // Use LoadFromAssemblyPath so the assembly retains its path for dependency resolution.
                asm = AssemblyLoadContext.Default.LoadFromAssemblyPath(fullPath);
            }

            if (asm is null)
                throw new TypeLoadException(
                    $"Could not resolve assembly for '{row.TypeFullName}'. " +
                    $"AssemblyName='{row.AssemblyName ?? "<null>"}', AssemblyPath='{row.AssemblyPath ?? "<null>"}'.");

            // 4) Find the type in that assembly
            var type = asm.GetType(row.TypeFullName, throwOnError: false, ignoreCase: false)
                    ?? asm.GetType(row.TypeFullName, throwOnError: false, ignoreCase: true); // last-chance, case-insensitive

            if (type is null)
            {
                // Helpful hint if the short name matches something exported
                var shortName = row.TypeFullName.Split('.').Last();
                var hint = asm.ExportedTypes.FirstOrDefault(t => string.Equals(t.Name, shortName, StringComparison.OrdinalIgnoreCase));
                var suggestion = hint is not null ? $" Did you mean '{hint.FullName}'?" : string.Empty;

                throw new TypeLoadException(
                    $"Type '{row.TypeFullName}' not found in assembly '{asm.FullName}'.{suggestion}");
            }
            return ValidateTemplateType(type);
        }

        private static Type ValidateTemplateType(Type t)
        {
            if (!t.IsClass || t.IsAbstract || !(t.IsPublic || t.IsNestedPublic))
                throw new TypeLoadException($"Type '{t.FullName}' is not a public, concrete class.");
            return t;
        }

        // --- normalization helpers ---
        private static string NormalizePartner(string v) => (v ?? "*").Trim().ToUpperInvariant();

        private static string NormalizeVersion(string v)
        {
            var d = new string((v ?? "").Where(char.IsDigit).ToArray());
            if (d.Length == 5) d += "0";            // ISA12 like "00406" -> "004060"
            return d.PadLeft(6, '0')[..6];          // "005010X221A1" -> "005010"
        }
    }

    public sealed record TemplateRow(
        int Id,
        string PartnerKey,
        string VersionNorm,
        string St01,
        string TypeFullName,
        string? AssemblyName,
        string? AssemblyPath,
        bool IsEnabled,
        bool IsStrict,
        int Priority,
        DateTime? EffectiveFromUtc,
        DateTime? EffectiveToUtc
    );

    public sealed record TemplateDescriptor(
        Type Type,
        Assembly Assembly,
        string PartnerKey,
        string VersionNorm,
        string St01,
        string TypeFullName,
        string? AssemblyName,
        string? AssemblyPath);

    // Very small logger shim so you don't need Serilog here.
    public interface ILogger
    {
        void Debug(string messageTemplate, params object?[]? args);
        void Warning(string messageTemplate, params object?[]? args);
        void Error(Exception ex, string messageTemplate, params object?[]? args);
    }

    public sealed class NullLogger : ILogger
    {
        public void Debug(string _, params object?[]? __) { }
        public void Warning(string _, params object?[]? __) { }
        public void Error(Exception __, string ___, params object?[]? ____) { }
    }

    public sealed class SerilogAdapter : ILogger
    {
        private readonly Serilog.ILogger _log;
        public SerilogAdapter(Serilog.ILogger log) => _log = log;
        public void Debug(string m, params object?[]? a) => _log.Debug(m, a ?? Array.Empty<object?>());
        public void Warning(string m, params object?[]? a) => _log.Warning(m, a ?? Array.Empty<object?>());
        public void Error(Exception ex, string m, params object?[]? a)  => _log.Error(ex, m, a ?? Array.Empty<object?>());
    }
}
