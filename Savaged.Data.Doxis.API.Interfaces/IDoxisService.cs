using System.Net.Http;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisService
{
    HttpVerb Verb { get; }

    string EndPoint { get; }

    Task<string> GetResponseBodyAsync(string body = "");
}
