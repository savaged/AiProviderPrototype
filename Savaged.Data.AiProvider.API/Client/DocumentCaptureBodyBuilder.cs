using Savaged.Data.AiProvider.API.Interfaces;
using Savaged.Data.AiProvider.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.AiProvider.API.Client;

public class DocumentCaptureBodyBuilder : IBodyBuilder
{
    public async Task<string> BuildAsync(string fileId)
    {
        var data = new List<Document>
        {
            new(fileId)
        };
        await Task.CompletedTask;
        return data.ToJson();
    }
}
