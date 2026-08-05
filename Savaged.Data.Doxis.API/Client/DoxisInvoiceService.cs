using Savaged.Data.Doxis.API.Interfaces;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class DoxisInvoiceService : IDoxisInvoiceService
{
    private readonly IDictionary<string, IDoxisService> _repository;
    private readonly IBodyBuilder _saveToStorageBodyBuilder;
    private readonly IResponseDeconstructor _saveToStorageResponseDeconstructor;
    private readonly IBodyBuilder _documentCaptureBodyBuilder;

    public DoxisServiceRepository(
        IDoxisService saveToStorageService,
        IBodyBuilder saveToStorageBodyBuilder,
        IDoxisService captureFinancialService,
        IResponseDeconstructor saveToStorageResponseDeconstructor,
        IBodyBuilder documentCaptureBodyBuilder)
    {
        _repository = new Dictionary<string, IDoxisService>();
        _repository.Add(SAVE_TO_STORAGE_SERVICE_END_POINT, saveToStorageService);
        _repository.Add(CAPTURE_FINANCIAL_SERVICE_END_POINT, captureFinancialService);
        _saveToStorageBodyBuilder = saveToStorageBodyBuilder;
        _saveToStorageResponseDeconstructor = saveToStorageResponseDeconstructor;
        _documentCaptureBodyBuilder = documentCaptureBodyBuilder;
    }

    public const string SAVE_TO_STORAGE_SERVICE_END_POINT = "storage/v1/files";
    public const string CAPTURE_FINANCIAL_SERVICE_END_POINT = "document_capturing/v1/financial";

    public async Task<string> CaptureFinancialAsync(string fileLocation)
    {
        var uploadResponse = _saveToStorageResponseDeconstructor.Deconstruct(
            await SaveToStorageAsync(fileLocation));
        var body = _documentCaptureBodyBuilder.Build(uploadResponse.data.file_id);
        var service = _repository[CAPTURE_FINANCIAL_SERVICE_END_POINT];
        return await service.EnactAsync(body);
    }

    private async Task<string> SaveToStorageAsync(string fileLocation)
    {
        var body = await _saveToStorageBodyBuilder.BuildAsync(fileLocation);
        var service = _repository[SAVE_TO_STORAGE_SERVICE_END_POINT];
        return await service.EnactAsync(body);
    }
}
