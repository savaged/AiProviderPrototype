using Savaged.Data.Interfaces;
using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Models;
using Savaged.Core.Extensions;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class DocumentCaptureBodyBuilder : IBodyBuilder
{
    public async Task<string> BuildAsync(string fileId)
    {
        var data = new List<Document>
        {
            new Document(fileId)
        };
        await Task.Completed();
        return data.ToJson();
    }
}
