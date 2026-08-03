using Savaged.Data.Doxis.API.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Client;

public class DoxisClient : IDoxisClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _apiKey;

    public DoxisClient(HttpClient httpClient, string baseUrl, string apiKey)
    {
        _httpClient = httpClient;
        _baseUrl = baseUrl;
        _apiKey = apiKey;
    }

    public async Task<HttpResponseMessage> GetResponseAsync(string endPoint)
    {
        _httpClient.DefaultRequestHeaders.Add("x-api-key", _apiKey);
        return await _httpClient.GetAsync($"{_baseUrl}{endPoint}");
    }

}
