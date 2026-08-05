using Savaged.Data.FileIO;
using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Client;

if (args.Length != 1)
{
    Console.WriteLine("Please supply an invoice location");
    return;
}
Console.WriteLine("Emulating DI");

IDoxisClient client = new DoxisClient(
    new HttpClient(),
    "https://dochorizon.klippa.com/api/services/",
    DoxisConfig.GetApiKey());

IDoxisInvoiceService dis = new DoxisInvoiceService(
    new DoxisService(client, DoxisInvoiceService.SAVE_TO_STORAGE_SERVICE_END_POINT),
    new SaveToStorageBodyBuilder(new LocalFileService()),
    new DoxisService(client, DoxisInvoiceService.CAPTURE_FINANCIAL_SERVICE_END_POINT),
    new SaveToStorageResponseDeconstructor(),
    new DocumentCaptureBodyBuilder()
    );

Console.WriteLine("Running");

var result = await dis.CaptureFinancialAsync(args[0]);

Console.WriteLine(result);

