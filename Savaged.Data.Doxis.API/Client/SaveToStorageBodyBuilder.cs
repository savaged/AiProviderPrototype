using Savaged.Data.Interfaces;
using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Models;
using Savaged.Core.Extensions;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class SaveToStorageBodyBuilder : IBodyBuilder
{
    private readonly ILocalFileService _localFileService;

    public SaveToStorageBodyBuilder(ILocalFileService localFileService)
    {
        _localFileService = localFileService;
    }

    public async Task<string> BuildAsync(string fileLocation)
    {
        var stream = await _localFileService.OpenReadAsync(fileLocation);
        var data = new Upload(stream.ToBase64());
        return data.ToJson();
    }
}
