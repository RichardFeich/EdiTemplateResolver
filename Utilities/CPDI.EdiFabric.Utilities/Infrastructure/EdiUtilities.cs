using EdiFabric.Core.Model.Edi;

namespace CPDI.EdiFabric.Utilities.Infrastructure
{
    public static class EdiUtilities
    {
        public static string GetControlNumber(EdiMessage msg)
        {
            var st = msg.GetType().GetProperty("ST")?.GetValue(msg);
            return st?.GetType()
                     .GetProperty("TransactionSetControlNumber_02")?
                     .GetValue(st)?.ToString() ?? "?";
        }
    }
}
