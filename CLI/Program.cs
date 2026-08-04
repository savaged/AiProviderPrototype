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

IDoxisServiceRepository repos = new DoxisServiceRepository(
    new DoxisService(client, DoxisServiceRepository.SAVE_TO_STORAGE_SERVICE_END_POINT),
    new SaveToStorageBodyBuilder(),
    new DoxisService(client, DoxisServiceRepository.CAPTURE_FINANCIAL_SERVICE_END_POINT)
    );

Console.WriteLine("Running");

var result = await repos.SaveToStorageAsync(args[0]);
Console.WriteLine(result);

