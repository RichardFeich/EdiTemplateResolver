using System.Reflection;
using CPDI.EdiFabric.Utilities.Interfaces;
using EdiGS = global::EdiFabric.Core.Model.Edi.X12.GS;
using EdiISA = global::EdiFabric.Core.Model.Edi.X12.ISA;
using EdiST = global::EdiFabric.Core.Model.Edi.X12.ST;

namespace CPDI.EdiFabric.Utilities
{
    public sealed class DbTemplateFactory
    {
        private readonly IEdiTemplateResolver _resolver;
        private readonly Func<EdiISA, string> _partnerSelector;

        public DbTemplateFactory(IEdiTemplateResolver resolver, Func<EdiISA, string>? partnerSelector = null)
        {
            _resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
            _partnerSelector = partnerSelector ?? DefaultPartnerSelector;
        }

        // ---- Core resolution: TypeInfo first (ideal for X12Reader) ----
        public TypeInfo CreateTypeInfo(EdiISA isa, EdiGS gs, EdiST st)
        {
            if (isa is null) throw new ArgumentNullException(nameof(isa));
            if (st is null) throw new ArgumentNullException(nameof(st));

            var st01 = st.TransactionSetIdentifierCode_01?.Trim()
                       ?? throw new NotSupportedException("Missing ST01.");

            var version = NormalizeVersion(gs?.VersionAndRelease_8, isa.InterchangeControlVersionNumber_12);
            var partner = NormalizePartner(_partnerSelector(isa));

            return _resolver.ResolveTypeInfo(partner, version, st01);
        }

        // Adapter for callers that want System.Type
        public Type Create(EdiISA isa, EdiGS gs, EdiST st) => CreateTypeInfo(isa, gs, st).AsType();

        // Ready-to-pass delegates (nice for DI)
        public Func<EdiISA, EdiGS, EdiST, TypeInfo> AsTypeInfoDelegate() => CreateTypeInfo;
        public Func<EdiISA, EdiGS, EdiST, Type> AsTypeDelegate() => Create;

        // ---- Helpers ----

        private static string DefaultPartnerSelector(EdiISA isa)
        {
            static string? T(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

            // Always available in your version:
            var senderId = T(isa.InterchangeSenderID_6);
            var receiverId = T(isa.InterchangeReceiverID_8);

            // Try to read ISA05 / ISA07 qualifiers if this model exposes them; otherwise null.
            string? q5 = GetStringProp(isa,
                        "InterchangeIDQualifier_5",
                        "InterchangeIDQualifier_05",
                        "ISA05_InterchangeIDQualifier");   // try common variants
            string? q7 = GetStringProp(isa,
                        "InterchangeIDQualifier_7",
                        "InterchangeIDQualifier_07",
                        "ISA07_InterchangeIDQualifier");

            if (!string.IsNullOrEmpty(senderId))
                return string.IsNullOrWhiteSpace(q5) ? senderId : $"{q5.Trim()}:{senderId}";

            if (!string.IsNullOrEmpty(receiverId))
                return string.IsNullOrWhiteSpace(q7) ? receiverId : $"{q7.Trim()}:{receiverId}";

            return "*";
        }

        private static string? GetStringProp(object obj, params string[] names)
        {
            var t = obj.GetType();
            foreach (var n in names)
            {
                var p = t.GetProperty(n, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (p != null && p.PropertyType == typeof(string))
                    return (string?)p.GetValue(obj);
            }
            return null;
        }

        private static string NormalizePartner(string? p) =>
            string.IsNullOrWhiteSpace(p) ? "*" : p.Trim();

        private static string NormalizeVersion(string? gs08, string? isa12)
        {
            var v = (gs08 ?? isa12)?.Trim();
            if (string.IsNullOrEmpty(v)) return "004010";

            v = v.ToUpperInvariant();

            // Common cases: "004010X091A1" -> "004010", "4010" -> "004010"
            if (v.StartsWith("0040", StringComparison.Ordinal))
                return v.Length >= 6 ? v[..6] : v.PadRight(6, '0');

            if (v.Length == 4 && v.EndsWith("10", StringComparison.Ordinal))
                return "00" + v;

            // Fallback: take leading 6 chars if available, else pad/trim
            return v.Length >= 6 ? v[..6] : v.PadLeft(6, '0');
        }
    }
}
