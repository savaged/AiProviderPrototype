using Savaged.Data.AiProvider.API.Interfaces;
using Savaged.Data.AiProvider.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.AiProvider.API.Client;

public class DocumentCaptureBodyBuilder : IBodyBuilder
{
    public async Task<string> BuildAsync(string fileId)
    {
        var request = new
        {
            documents = new[]
            {
                new
                {
                    file_id = fileId
                }
            },
            configuration = new
            {
                slug = "invoices"
            }
        };
        return request.ToJson();
    }
}
