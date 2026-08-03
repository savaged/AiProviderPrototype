using Savaged.Data.Doxis.API.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class DoxisService : IDoxisService
{
    private readonly IDoxisClient _doxisClient;

    public DoxisService(IDoxisClient doxisClient, string endPoint)
    {
        _doxisClient = doxisClient;
        EndPoint = endPoint;
    }

    public string EndPoint { get; }

    public async Task<string> GetResponseBodyAsync()
    {
        var response = await _doxisClient.GetResponseAsync(EndPoint);
        if (!response.IsSuccessStatusCode)
            return response.StatusCode.ToString();
        return await response.Content.ReadAsStringAsync();
    }

}
