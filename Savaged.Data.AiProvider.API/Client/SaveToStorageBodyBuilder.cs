using Savaged.Data.Interfaces;
using Savaged.Data.AiProvider.API.Interfaces;
using Savaged.Data.AiProvider.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.AiProvider.API.Client;

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
        if (stream == Stream.Null)
            return $"File not found at {fileLocation}!";
        var data = new Upload(stream.ToBase64());
        return data.ToJson();
    }
}
