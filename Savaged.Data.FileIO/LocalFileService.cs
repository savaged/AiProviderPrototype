using Savaged.Data.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace Savaged.Data.FileIO;

public class LocalFileService : ILocalFileService
{
    public async Task<Stream> OpenReadAsync(string fileLocation)
    {
        if (!File.Exists(fileLocation))
            return Stream.Null;
        await Task.CompletedTask;
        return File.OpenRead(fileLocation);
    }
}
