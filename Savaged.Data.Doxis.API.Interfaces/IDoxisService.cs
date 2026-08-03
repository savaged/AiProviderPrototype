using System.Net.Http;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisService
{
    string EndPoint { get; }

    Task<string> GetResponseBodyAsync();
}
