using Savaged.Data.FileIO;
using Savaged.Data.AiProvider.API.Interfaces;
using Savaged.Data.AiProvider.API.Client;

if (args.Length != 1)
{
    Console.WriteLine("Please supply an invoice location");
    return;
}
Console.WriteLine("Emulating DI");

IAiProviderClient client = new AiProviderClient(
    new HttpClient(),
    "https://dochorizon.klippa.com/api/services/",
    AiProviderConfig.GetApiKey());

IAiProviderInvoiceService dis = new AiProviderInvoiceService(
    new AiProviderService(client, AiProviderInvoiceService.SAVE_TO_STORAGE_SERVICE_END_POINT),
    new SaveToStorageBodyBuilder(new LocalFileService()),
    new AiProviderService(client, AiProviderInvoiceService.CAPTURE_FINANCIAL_SERVICE_END_POINT),
    new SaveToStorageResponseDeconstructor(),
    new DocumentCaptureBodyBuilder()
    );

Console.WriteLine("Running");

var result = await dis.CaptureFinancialAsync(args[0]);

Console.WriteLine(result);

