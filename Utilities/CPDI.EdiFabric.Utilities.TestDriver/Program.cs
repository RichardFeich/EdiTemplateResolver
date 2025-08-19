using CPDI.Edi.X12.Abstractions;
using CPDI.EdiFabric.Utilities;
using CPDI.EdiFabric.Utilities.Infrastructure;
using CPDI.EdiFabric.Utilities.Interfaces;
using CPDI.EdiFabric.Utilities.Models;
using CPDI.EdiFabric.Utilities.TestDriver;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;

EdiFabric.SerialKey.Set("ca157c4e10e14ef1990daa75ae3be4f8");
var connString = "Data Source=CPDIWS11-78;Initial Catalog=As2Gateway;Integrated Security=False;Persist Security Info=False;TrustServerCertificate=Yes;User ID=as2gwuser;Password=tec0617";

string baseDir = AppContext.BaseDirectory;

string ediFilePath = Path.Combine(baseDir, "EdiDocs", "2224315_2023-12-01T01_37_11.txt");       // Ace
//string ediFilePath = Path.Combine(baseDir, "EdiDocs", "008086593_2025-03-14T15_36_38.txt");     //Acme
//string ediFilePath = Path.Combine(baseDir, "EdiDocs", "5503361742_2024-01-12T19_02_58.txt");    // No Partner alias - use default template
//string ediFilePath = Path.Combine(baseDir, "EdiDocs", "5503361742_2024-01-12T19_02_58.txt");

Console.WriteLine($"Using EDI file: {ediFilePath}\n\n");

using var stream = File.OpenRead(ediFilePath);

IEdiTemplateResolver resolver = new DbEdiTemplateResolver(connString);
var dbTemplateFactory = new DbTemplateFactory(resolver);

var readerSettings = new X12ReaderSettings { ContinueOnError = true };

//////////////////// Validator Test //////////////////////
var validator = new EdiValidator(dbTemplateFactory.CreateTypeInfo, readerSettings);
var validatorOptions = new EdiValidationOptions(
    Settings: new ValidationSettings(),   // optional: code sets / syntax set, etc.
    SortErrors: true,
    IncludeRawContext: true
);
var results = await validator.ValidateX12Async(stream, validatorOptions);

// Inspect results
foreach (var r in results)
{
    Console.WriteLine($"ST01:{r.Name} VERS:{r.Edition} REL:{r.Release} CN:{r.ControlNumber} -> {(r.IsValid ? "OK\n\n" : "INVALID\n\n")}");
    if (!r.IsValid)
    {
        Console.WriteLine("Codes: " + string.Join(", ", r.Codes));
        foreach (var line in r.Flattened) Console.WriteLine("  " + line);
    }
}
////////////////////////////////////////////////////////////

using var stream2 = File.OpenRead(ediFilePath);
using var ediReader = new X12Reader(
    stream2,
    dbTemplateFactory.CreateTypeInfo,
    readerSettings
);

var items = new List<IEdiItem>();
var readerErrors = new List<ReaderErrorContext>();

var partnerId = string.Empty;

while (ediReader.Read())
{
    Console.WriteLine($"Type:{ediReader.Item}");
    switch (ediReader.Item)
    {
        case ITS850 po: DummyHandlers.Handle850(po); break;
        case ITS855 ack: DummyHandlers.Handle855(ack); break;
        case ITS856 asn: DummyHandlers.Handle856(asn); break;
        case ITS940 wso: DummyHandlers.Handle940(wso); break;
        default: break;
    }

    if (ediReader.Item is ISA isa)
    {
        // Example: Receiver ID from ISA08, Sender ID from ISA06
        partnerId = isa.InterchangeSenderID_6;
    }

    if (ediReader.Item is ReaderErrorContext rec)
    {
        readerErrors.Add(rec);
    }
    else
    {
        items.Add(ediReader.Item);
    }
}

