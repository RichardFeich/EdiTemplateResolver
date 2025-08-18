
using CPDI.EdiFabric.Utilities.Models;

namespace CPDI.EdiFabric.Utilities.WebValidator.Service
{
    public interface IEdiValidationService
    {
        Task<EdiValidationSummary> ValidateAsync(Stream ediStream, CancellationToken ct = default);
    }
}
