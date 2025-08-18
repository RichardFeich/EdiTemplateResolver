using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.Loader;

namespace CPDI.EdiFabric.Utilities.Infrastructure
{
    public sealed class TemplateLoader
    {
        private readonly ILogger _log;
        private readonly AssemblyLoadContext _alc;
        private readonly Func<Type, bool> _typeValidator;
        private readonly ConcurrentDictionary<string, TemplateDescriptor> _cache = new();

        public TemplateLoader(ILogger? logger = null, AssemblyLoadContext? alc = null, Func<Type, bool>? typeValidator = null)
        {
            _log = logger ?? new NullLogger();
            _alc = alc ?? AssemblyLoadContext.Default;
            _typeValidator = typeValidator ?? (t => t.IsClass && !t.IsAbstract && (t.IsPublic || t.IsNestedPublic));
        }

        public void ClearCache() => _cache.Clear();

        public bool TryPreload(string assemblyNameOrPath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(assemblyNameOrPath)) return false;

                // If it looks like a file, load from path; else treat as simple/qualified name.
                if (assemblyNameOrPath.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) ||
                    assemblyNameOrPath.Contains(Path.DirectorySeparatorChar) ||
                    assemblyNameOrPath.Contains(Path.AltDirectorySeparatorChar))
                {
                    var full = Path.GetFullPath(assemblyNameOrPath);
                    if (!File.Exists(full))
                    {
                        _log.Warning("Preload failed: file not found {0}", full);
                        return false;
                    }
                    _ = _alc.LoadFromAssemblyPath(full);
                    return true;
                }
                else
                {
                    _ = Assembly.Load(new AssemblyName(assemblyNameOrPath));
                    return true;
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex, "Preload failed for {0}", assemblyNameOrPath);
                return false;
            }
        }

        public bool TryLoadTemplate(TemplateRow row, out TemplateDescriptor? descriptor)
        {
            descriptor = null;

            if (row is null || string.IsNullOrWhiteSpace(row.TypeFullName))
            {
                _log.Warning("Invalid template row.");
                return false;
            }

            var key = MakeCacheKey(row);
            if (_cache.TryGetValue(key, out var cached))
            {
                descriptor = cached;
                return true;
            }

            try
            {
                // 1) Resolve Assembly
                Assembly? asm = ResolveAssembly(row);
                if (asm is null)
                {
                    _log.Warning("Assembly not resolved for {0} (AsmName={1}, AsmPath={2})",
                        row.TypeFullName, row.AssemblyName, row.AssemblyPath);
                    return false;
                }

                // 2) Resolve Type
                var type = asm.GetType(row.TypeFullName, throwOnError: false, ignoreCase: false);
                if (type is null)
                {
                    _log.Warning("Type not found: {0} in {1}", row.TypeFullName, asm.FullName);
                    return false;
                }

                // 3) Validate Type
                if (!_typeValidator(type))
                {
                    _log.Warning("Type {0} did not pass validation.", row.TypeFullName);
                    return false;
                }

                // 4) Success -> cache
                var desc = new TemplateDescriptor(
                    Type: type,
                    Assembly: asm,
                    PartnerKey: row.PartnerKey,
                    VersionNorm: row.VersionNorm,
                    St01: row.St01,
                    TypeFullName: row.TypeFullName,
                    AssemblyName: row.AssemblyName,
                    AssemblyPath: row.AssemblyPath);

                _cache[key] = desc;
                descriptor = desc;

                _log.Debug("Loaded template {0} (Partner={1}, Ver={2}, ST01={3}, Pri={4})",
                    row.TypeFullName, row.PartnerKey, row.VersionNorm, row.St01, row.Priority);

                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex, "Unexpected error loading template {0}", row.TypeFullName);
                return false;
            }
        }

        public TemplateDescriptor LoadOrThrow(TemplateRow row)
            => TryLoadTemplate(row, out var desc)
                ? desc!
                : throw new InvalidOperationException($"Failed to load template {row?.TypeFullName}");

        // ---------- internals ----------

        private static string MakeCacheKey(TemplateRow r)
            => $"{r.PartnerKey}|{r.VersionNorm}|{r.St01}|{r.TypeFullName}|{r.AssemblyName}|{r.AssemblyPath}";

        private Assembly? ResolveAssembly(TemplateRow row)
        {
            Assembly? asm = null;

            // Prefer name
            if (!string.IsNullOrWhiteSpace(row.AssemblyName))
            {
                try
                {
                    asm = Assembly.Load(new AssemblyName(row.AssemblyName));
                }
                catch (Exception ex)
                {
                    _log.Debug("Assembly.Load by name failed for {0}: {1}", row.AssemblyName!, ex.Message);
                }
            }

            // Fallback to path
            if (asm is null && !string.IsNullOrWhiteSpace(row.AssemblyPath))
            {
                var fullPath = Path.GetFullPath(row.AssemblyPath);
                if (!File.Exists(fullPath))
                {
                    _log.Warning("AssemblyPath not found: {0}", fullPath);
                    return null;
                }

                try
                {
                    asm = _alc.LoadFromAssemblyPath(fullPath);
                }
                catch (Exception ex)
                {
                    _log.Warning("LoadFromAssemblyPath failed for {0}: {1}", fullPath, ex.Message);
                    return null;
                }
            }

            // Last attempt: search already-loaded by short name
            if (asm is null && !string.IsNullOrWhiteSpace(row.AssemblyName))
            {
                var shortName = new AssemblyName(row.AssemblyName).Name;
                asm = AppDomain.CurrentDomain
                               .GetAssemblies()
                               .FirstOrDefault(a =>
                                   string.Equals(a.GetName().Name, shortName, StringComparison.Ordinal));
            }

            return asm;
        }
    }

}
