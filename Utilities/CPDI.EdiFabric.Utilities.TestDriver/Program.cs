using CPDI.EdiFabric.Utilities;
using CPDI.EdiFabric.Utilities.Infrastructure;
using CPDI.EdiFabric.Utilities.Interfaces;
using CPDI.EdiFabric.Utilities.Models;
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

    //switch (item)
    //{
    //    case ITS850 po: Handle850(po); break;
    //    case ITS855 ack: Handle855(ack); break;
    //    case ITS856 asn: Handle856(asn); break;
    //    default: LogUnknown(item); break;
    //}


    if (ediReader.Item is ISA isa)
    {
        // Example: Receiver ID from ISA08, Sender ID from ISA06
        partnerId = isa.InterchangeSenderID_6;
    }

    switch (ediReader.Item)
    {
        case CPDI.EdiFabric.Templates.X12004010.Ace.TS940:                  // Ace Template Project Assembly, Custom Namespace/Type (template)
            Console.WriteLine($"1 - Found TS940 transaction from - {ediReader.Item.GetType().FullName} - {partnerId}");
            break;

        //case EdiFabric.Templates.X12004010_Ace.TS940:           // Default-Shared Assembly, Custom Namespace/Type
        //    Console.WriteLine($"2 - Found TS940 transaction from - {ediReader.Item.GetType().FullName} - {partnerId}");
        //    break;

        //case EdiFabric.Templates.X12004010.TS940:               // Default-Shared Assembly, Default Namespace
        //    Console.WriteLine($"3 - Found TS940 transaction from - {ediReader.Item.GetType().FullName} - {partnerId}");
        //    break;

        //case EdiFabric.Templates.X12004060.TS850:               // Default-Shared Assembly, Cloned Template from 4050    
        //    Console.WriteLine($"4 - Found TS850 transaction from {ediReader.Item.GetType().FullName} - {partnerId}");
        //    break;

        //case EdiFabric.Templates.X12004010_Ace_Dev.TS940:       // Default-Shared Assembly, Custom Namespace/Type DEVELOPMENT    
        //    Console.WriteLine($"5 - Found TS940 transaction from - {ediReader.Item.GetType().FullName} - {partnerId}");
        //    break;

        //case EdiFabric.Templates.X12004010.TS850:               // Default-Shared Assembly, Default Namespace
        //    Console.WriteLine($"6 - Found TS850 transaction from - {ediReader.Item.GetType().FullName} - {partnerId}");
        //    break;

        //case EdiFabric.Core.Model.Edi.EdiMessage m when m is not null:
        //    Console.WriteLine($"7 - Default message type: {m.GetType().FullName}  - {partnerId}");
        //    break;

        default:
            // null or non-EDI item (e.g., ReaderErrorContext)
            break;
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

