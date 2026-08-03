using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Client;

Console.WriteLine("Emulating DI");

IDoxisClient client = new DoxisClient(
    new HttpClient(),
    "https://dochorizon.klippa.com/api/services/",
    DoxisConfig.GetApiKey());

IDoxisServiceRepository repos = new DoxisServiceRepository(
    new DoxisService(client, DoxisServiceRepository.SAVE_TO_STORAGE_SERVICE_END_POINT),
    new DoxisService(client, DoxisServiceRepository.CAPTURE_FINANCIAL_SERVICE_END_POINT)
    );

Console.WriteLine("Running");

var result = await repos.SaveToStorageAsync();
Console.WriteLine(result);

