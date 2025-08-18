using EdiFabric.Core.Model.Edi;

namespace CPDI.EdiFabric.Utilities.Models
{
    public sealed record EdiValidationOptions(
        ValidationSettings? Settings = null,
        bool SortErrors = true,
        bool IncludeRawContext = false
    );
}
