namespace CPDI.EdiFabric.Utilities.TestDriver
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;
    using CPDI.Edi.X12.Abstractions;

    public static class DummyHandlers
    {
        // Handy counters you can assert on in tests
        public static readonly ConcurrentDictionary<string, int> Counts = new();

        // -------- sync versions ----------
        public static void Handle850(ITS850 po) => Handle("850", po);
        public static void Handle855(ITS855 ack) => Handle("855", ack);
        public static void Handle856(ITS856 asn) => Handle("856", asn);
        public static void Handle940(ITS940 wso) => Handle("940", wso);

        // -------- async versions ----------
        public static Task Handle850Async(ITS850 po, CancellationToken ct = default) => HandleAsync("850", po, ct);
        public static Task Handle855Async(ITS855 ack, CancellationToken ct = default) => HandleAsync("855", ack, ct);
        public static Task Handle856Async(ITS856 asn, CancellationToken ct = default) => HandleAsync("856", asn, ct);
        public static Task Handle940Async(ITS940 wso, CancellationToken ct = default) => HandleAsync("940", wso, ct);

        private static void Handle(string st01, IX12Transaction txn)
        {
            var typeName = txn?.GetType().FullName ?? "<null>";
            Counts.AddOrUpdate(st01, 1, (_, n) => n + 1);
            Console.WriteLine($"[Dummy] Handled ST{st01} with {typeName}");
        }

        private static Task HandleAsync(string st01, IX12Transaction txn, CancellationToken ct)
        {
            // No real async work—just keep the signature for future use
            Handle(st01, txn);
            return Task.CompletedTask;
        }
    }

}
