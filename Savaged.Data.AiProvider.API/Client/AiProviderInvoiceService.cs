using Savaged.Data.AiProvider.API.Interfaces;

namespace Savaged.Data.AiProvider.API.Client;

public class AiProviderInvoiceService : IAiProviderInvoiceService
{
    private readonly IDictionary<string, IAiProviderService> _doxisServiceRepository;
    private readonly IBodyBuilder _saveToStorageBodyBuilder;
    private readonly IResponseDeconstructor _saveToStorageResponseDeconstructor;
    private readonly IBodyBuilder _documentCaptureBodyBuilder;

    public AiProviderInvoiceService(
        IAiProviderService saveToStorageService,
        IBodyBuilder saveToStorageBodyBuilder,
        IAiProviderService captureFinancialService,
        IResponseDeconstructor saveToStorageResponseDeconstructor,
        IBodyBuilder documentCaptureBodyBuilder)
    {
        _doxisServiceRepository = new Dictionary<string, IAiProviderService>
        {
            { SAVE_TO_STORAGE_SERVICE_END_POINT, saveToStorageService },
            { CAPTURE_FINANCIAL_SERVICE_END_POINT, captureFinancialService }
        };
        _saveToStorageBodyBuilder = saveToStorageBodyBuilder;
        _saveToStorageResponseDeconstructor = saveToStorageResponseDeconstructor;
        _documentCaptureBodyBuilder = documentCaptureBodyBuilder;
    }

    public const string SAVE_TO_STORAGE_SERVICE_END_POINT = "storage/v1/files";
    public const string CAPTURE_FINANCIAL_SERVICE_END_POINT = "document_capturing/v1/financial";

    public async Task<string> CaptureFinancialAsync(string fileLocation)
    {
        var fileId = _saveToStorageResponseDeconstructor.Deconstruct(
            await SaveToStorageAsync(fileLocation))?.ToString() ?? string.Empty;
        var body = await _documentCaptureBodyBuilder.BuildAsync(fileId);
        var service = _doxisServiceRepository[CAPTURE_FINANCIAL_SERVICE_END_POINT];
        return await service.EnactAsync(body);
    }

    private async Task<string> SaveToStorageAsync(string fileLocation)
    {
        var body = await _saveToStorageBodyBuilder.BuildAsync(fileLocation);
        var service = _doxisServiceRepository[SAVE_TO_STORAGE_SERVICE_END_POINT];
        return await service.EnactAsync(body);
    }
}
