using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisServiceRepository
{
    Task<string> SaveToStorageAsync(string fileLocation);
    Task<string> CaptureFinancialAsync();
}
