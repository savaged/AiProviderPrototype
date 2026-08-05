using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.Doxis.API.Client;

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
