using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisServiceRepository
{
    Task<string> SaveToStorageAsync();
    Task<string> CaptureFinancialAsync();
}
