namespace Savaged.Data.AiProvider.API.Interfaces;

public interface IAiProviderInvoiceService
{
    Task<string> CaptureFinancialAsync(string fileLocation);
}
