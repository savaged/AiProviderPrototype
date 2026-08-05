namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisInvoiceService
{
    Task<string> CaptureFinancialAsync(string fileLocation);
}
