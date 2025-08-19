using System.Collections.Concurrent;
using CPDI.Edi.X12.Abstractions;
using CPDI.EdiFabric.Utilities.Infrastructure;
using EdiFabric.Framework.Readers;

// while (ediReader.Read())
// {
//     // ediReader.Item is the concrete template instance
//     DummyX12Harness.Route(ediReader.Item);
// }

// // In a test or after a run:
// DummyX12Harness.PrintSummary();
// // Assert a specific doc got handled:
// var handled850 = DummyX12Harness.Counts.GetValueOrDefault("850", 0);

namespace CPDI.EdiFabric.Utilities.Infrastructure
{
    public static class DummyX12Harness
    {
        // Per-ST01 counters you can assert on
        public static readonly ConcurrentDictionary<string, int> Counts = new();

        // -------- Router (call this for each parsed item) --------
        public static void Route(object? item)
        {
            switch (item)
            {
                case ITS810 x: Handle810(x); break;
                case ITS846 x: Handle846(x); break;
                //case ITS756 x: Handle756(x); break;
                case ITS880 x: Handle880(x); break;
                //case ITS994 x: Handle994(x); break;
                case ITS945 x: Handle945(x); break;
                case ITS850 x: Handle850(x); break;
                case ITS860 x: Handle860(x); break;
                case ITS875 x: Handle875(x); break;
                case ITS876 x: Handle876(x); break;
                case ITS940 x: Handle940(x); break;

                default:
                    Console.WriteLine($"[Dummy] Unrecognized: {item?.GetType().FullName ?? "<null>"}");
                    break;
            }
        }

        // Convenience for batches
        public static void RouteMany(IEnumerable<object?> items)
        {
            foreach (var it in items) Route(it);
        }

        // Reset between tests
        public static void Reset() => Counts.Clear();

        // Print a quick summary
        public static void PrintSummary()
        {
            Console.WriteLine("=== Dummy X12 Summary ===");
            foreach (var kv in Counts) Console.WriteLine($"ST{kv.Key}: {kv.Value}");
        }

        // -------- One tiny handler per ST type (increments + logs) --------
        public static void Handle810(ITS810 x) => Hit("810", x);
        public static void Handle846(ITS846 x) => Hit("846", x);
        //public static void Handle756(ITS756 x) => Hit("756", x);
        public static void Handle880(ITS880 x) => Hit("880", x);
        //public static void Handle994(ITS994 x) => Hit("994", x);
        public static void Handle945(ITS945 x) => Hit("945", x);
        public static void Handle850(ITS850 x) => Hit("850", x);
        public static void Handle860(ITS860 x) => Hit("860", x);
        public static void Handle875(ITS875 x) => Hit("875", x);
        public static void Handle876(ITS876 x) => Hit("876", x);
        public static void Handle940(ITS940 x) => Hit("940", x);

        private static void Hit(string st01, IX12Transaction doc)
        {
            Counts.AddOrUpdate(st01, 1, (_, n) => n + 1);
            Console.WriteLine($"[Dummy] Handled ST{st01} with {doc.GetType().FullName}");
        }
    }

}
