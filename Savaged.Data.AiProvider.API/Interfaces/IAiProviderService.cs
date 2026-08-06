using System.Net.Http;
using System.Threading.Tasks;

namespace Savaged.Data.AiProvider.API.Interfaces;

public interface IAiProviderService
{
    HttpVerb Verb { get; }

    string EndPoint { get; }

    Task<string> EnactAsync(string body = "");
}
