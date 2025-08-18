using CPDI.EdiFabric.Utilities.Models;

namespace CPDI.EdiFabric.Utilities.Interfaces
{
    public interface IEdiValidator
    {
        Task<IReadOnlyList<EdiValidationItemResult>> ValidateX12Async(
            Stream ediStream,
            EdiValidationOptions? options = null,
            CancellationToken ct = default);
    }
}
