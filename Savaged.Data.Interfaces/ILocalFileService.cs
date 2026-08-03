using System.IO;
using System.Threading.Tasks;

namespace Savaged.Data.Interfaces;

public interface ILocalFileService
{
    Task<Stream> OpenReadAsync(string fileLocation);
}
