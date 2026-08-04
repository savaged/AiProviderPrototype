using Savaged.Data.Doxis.API.Interfaces;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class DoxisServiceRepository : IDoxisServiceRepository
{
    private readonly IDictionary<string, IDoxisService> _repository;
    private readonly IBodyBuilder _saveToStorageBodyBuilder;

    public DoxisServiceRepository(
        IDoxisService saveToStorageService,
        IBodyBuilder saveToStorageBodyBuilder,
        IDoxisService captureFinancialService)
    {
        _repository = new Dictionary<string, IDoxisService>();
        _repository.Add(SAVE_TO_STORAGE_SERVICE_END_POINT, saveToStorageService);
        _repository.Add(CAPTURE_FINANCIAL_SERVICE_END_POINT, captureFinancialService);
        _saveToStorageBodyBuilder = saveToStorageBodyBuilder;
    }

    public const string SAVE_TO_STORAGE_SERVICE_END_POINT = "storage/v1/files";
    public const string CAPTURE_FINANCIAL_SERVICE_END_POINT = "document_capturing/v1/financial";

    public async Task<string> SaveToStorageAsync(string fileLocation)
    {
        var body = await _saveToStorageBodyBuilder.BuildAsync(fileLocation);
        var service = _repository[SAVE_TO_STORAGE_SERVICE_END_POINT];
        return await service.EnactAsync(body);
    }

    public async Task<string> CaptureFinancialAsync()
    {
        var body = "todo";
        var service = _repository[CAPTURE_FINANCIAL_SERVICE_END_POINT];
        return await service.EnactAsync(body);
    }
}
