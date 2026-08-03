using Savaged.Data.Doxis.API.Interfaces;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class DoxisServiceRepository : IDoxisServiceRepository
{
    private readonly IDictionary<string, IDoxisService> _repository;

    public DoxisServiceRepository(
        IDoxisService saveToStorageService,
        IDoxisService captureFinancialService)
    {
        _repository = new Dictionary<string, IDoxisService>();
        _repository.Add(SAVE_TO_STORAGE_SERVICE_END_POINT, saveToStorageService);
        _repository.Add(CAPTURE_FINANCIAL_SERVICE_END_POINT, captureFinancialService);
    }

    public const string SAVE_TO_STORAGE_SERVICE_END_POINT = "document_capturing/v1/files";
    public const string CAPTURE_FINANCIAL_SERVICE_END_POINT = "document_capturing/v1/financial";

    public async Task<string> SaveToStorageAsync()
    {
        var service = _repository[SAVE_TO_STORAGE_SERVICE_END_POINT ];
        return await service.GetResponseBodyAsync();
    }

    public async Task<string> CaptureFinancialAsync()
    {
        var service = _repository[CAPTURE_FINANCIAL_SERVICE_END_POINT];
        return await service.GetResponseBodyAsync();
    }
}
