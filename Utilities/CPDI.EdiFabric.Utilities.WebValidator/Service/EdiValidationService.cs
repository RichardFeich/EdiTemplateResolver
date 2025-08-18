using CPDI.EdiFabric.Utilities.Infrastructure;
using CPDI.EdiFabric.Utilities.Interfaces;
using CPDI.EdiFabric.Utilities.Models;
using CPDI.EdiFabric.Utilities.WebValidator.Models;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiValidationSummary = CPDI.EdiFabric.Utilities.Models.EdiValidationSummary;

namespace CPDI.EdiFabric.Utilities.WebValidator.Service
{
    public sealed class EdiValidationService : IEdiValidationService
    {
        private readonly string _connectionString;
        private readonly ILogger<EdiValidationService> _log;
        private readonly X12ReaderSettings _readerSettings = new()
        {
            ContinueOnError = true
        };

        private readonly ValidationSettings _validationSettings = new();

        public EdiValidationService(IConfiguration config, ILogger<EdiValidationService> log)
        {
            _connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Missing As2Gateway connection string.");;
            _log = log;
        }

        public async Task<EdiValidationSummary> ValidateAsync(Stream ediStream, CancellationToken ct = default)
        {
            Stream input = ediStream;
            MemoryStream? buffer = null;

            if (!ediStream.CanSeek)
            {
                buffer = new MemoryStream();
                await ediStream.CopyToAsync(buffer, ct);
                buffer.Position = 0;
                input = buffer;
            }

            try
            {

                IEdiTemplateResolver resolver = new DbEdiTemplateResolver(_connectionString);
                var dbTemplateFactory = new DbTemplateFactory(resolver);

                var readerSettings = new X12ReaderSettings { ContinueOnError = true };

                //////////////////// Validator Test //////////////////////
                var validator = new EdiValidator(dbTemplateFactory.CreateTypeInfo, readerSettings);

                var validatorOptions = new EdiValidationOptions(
                    Settings: new ValidationSettings(),   // optional: code sets / syntax set, etc.
                    SortErrors: true,
                    IncludeRawContext: true
                );

                var results = await validator.ValidateX12Async(ediStream, validatorOptions);

                // 5) Map results to DTOs
                var items = results?.ToList() ?? new List<Utilities.Models.EdiValidationItemResult>();

                if (results is not null)
                {
                    foreach (var r in results)
                    {
                        var templateType = r.GetType();
                        var templateFullName = templateType.FullName;                 // e.g., "EdiFabric.Templates.X12004010.TS850"
                        var templateAsmName = templateType.Assembly.GetName().Name;   // e.g., "EdiFabric.Templates.X1200
                        var codes = r.Codes;
                        var flat = r.Flattened;
                        var ctx = r.RawContext; // MessageErrorContext?
                    }
                }
                var summary = new EdiValidationSummary(
                        IsValid: items.All(i => i.IsValid),
                        ItemsCount: items.Count,
                        SelectedTemplateFullName: items.FirstOrDefault()?.TemplateFullName,
                        SelectedTemplateAssembly: items.FirstOrDefault()?.TemplateAssemblyName,
                        Items: items,
                        Messages: items.SelectMany(i => i.RawContext?.Flatten() ?? i.Flattened).ToArray());
                return summary;


            }
            finally
            {
                buffer?.Dispose();
            }

        }
    }
}
