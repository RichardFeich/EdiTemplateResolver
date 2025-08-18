using System.Reflection;
using CPDI.EdiFabric.Utilities.Models;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;

namespace CPDI.EdiFabric.Utilities.Infrastructure
{
    public sealed class EdiValidator : Interfaces.IEdiValidator
    {
        private readonly Func<ISA, GS, ST, TypeInfo> _typeFactory;
        private readonly X12ReaderSettings _readerSettings;

        public EdiValidator(Func<ISA, GS, ST, TypeInfo> typeFactory, X12ReaderSettings? readerSettings = null)
        {
            _typeFactory = typeFactory ?? throw new ArgumentNullException(nameof(typeFactory));
            _readerSettings = readerSettings ?? new X12ReaderSettings();
        }

        public async Task<IReadOnlyList<EdiValidationItemResult>> ValidateX12Async(
            Stream ediStream,
            EdiValidationOptions? options = null,
            CancellationToken cancellationToken = default)
        {
            if (ediStream is null) throw new ArgumentNullException(nameof(ediStream));
            options ??= new EdiValidationOptions();

            var results = new List<EdiValidationItemResult>(8);

            using var reader = new X12Reader(ediStream, _typeFactory, _readerSettings);

            while (!reader.Eof)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (!reader.Read()) break;

                if (reader.Item is EdiMessage msg)
                {
                    var templateType = msg.GetType();
                    var templateFullName = templateType.FullName;                 // e.g., "EdiFabric.Templates.X12004010.TS850"
                    var templateAsmName = templateType.Assembly.GetName().Name;
                    Console.WriteLine($"Validated with template: {templateFullName} [{templateAsmName}]\n\n");

                    var ok = msg.IsValid(out MessageErrorContext? ctx, options.Settings);

                    if (ctx != null && options.SortErrors)
                        ctx.Sort();

                    results.Add(Project(msg, ctx, ok, options.IncludeRawContext));
                }
            }

            return await Task.FromResult(results);

            static EdiValidationItemResult Project(EdiMessage? msg, MessageErrorContext? ctx, bool ok, bool includeRaw)
            {
                var templateType = msg?.GetType();
                var templateFullName = templateType?.FullName;
                var templateAsmName = templateType?.Assembly?.GetName().Name;

                var codes = ctx?.Codes is { Count: > 0 }
                    ? ctx.Codes.Select(c => c.ToString()).ToArray()
                    : Array.Empty<string>();

                var flat = ctx?.Flatten()?.ToArray() ?? Array.Empty<string>();

                return new EdiValidationItemResult(
                    IsValid: ok,
                    Name: ctx?.Name,
                    ControlNumber: ctx?.ControlNumber,
                    Edition: ctx?.Edition,
                    Release: ctx?.Release,
                    Index: ctx?.Index ?? -1,
                    ValidatedSegmentsCount: ctx?.ValidatedSegmentsCount ?? 0,
                    HasErrors: ctx?.HasErrors ?? !ok,
                    Codes: codes,
                    Flattened: flat,
                    TemplateFullName: templateFullName,
                    TemplateAssemblyName: templateAsmName,
                    RawContext: includeRaw ? ctx : null
                );
            }
        }
    }
}
