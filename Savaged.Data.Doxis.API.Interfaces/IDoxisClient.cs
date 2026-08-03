using System.Net.Http;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisClient
{
    Task<HttpResponseMessage> GetResponseAsync(string endPoint);
}
