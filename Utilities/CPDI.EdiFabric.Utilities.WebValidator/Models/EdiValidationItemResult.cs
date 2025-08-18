using EdiFabric.Core.Model.Edi.ErrorContexts;
namespace CPDI.EdiFabric.Utilities.WebValidator.Models
{
    public sealed record EdiValidationItemResult(
            bool IsValid,
            string? Name,
            string? ControlNumber,
            string? Edition,
            string? Release,
            int Index,
            int ValidatedSegmentsCount,
            bool HasErrors,
            IReadOnlyList<string> Codes,
            IReadOnlyList<string> Flattened,
            string? TemplateFullName,
            string? TemplateAssemblyName,
            MessageErrorContext? RawContext
    );
}
