using Savaged.Data.AiProvider.API.Interfaces;
using System.Text;

namespace Savaged.Data.AiProvider.API.Client;

public class AiProviderClient : IAiProviderClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _apiKey;

    public AiProviderClient(
        HttpClient httpClient,
        string baseUrl,
        string apiKey)
    {
        _httpClient = httpClient;
        _baseUrl = baseUrl;
        _apiKey = apiKey;
    }

    public async Task<HttpResponseMessage> GetResponseAsync(
        HttpVerb verb,
        string endPoint,
        string body = "")
    {
        AddHeader();
        var url = $"{_baseUrl}{endPoint}";
        switch (verb)
        {
            case HttpVerb.GET:
                return await _httpClient.GetAsync(url);
            case HttpVerb.DELETE:
                return await _httpClient.DeleteAsync(url);
            default:
                return await _httpClient.PostAsync(url, ConvertToContent(body));
        }
    }

    private void AddHeader() =>
        _httpClient.DefaultRequestHeaders.Add("x-api-key", _apiKey);

    private StringContent ConvertToContent(string body) =>
        new StringContent(body, Encoding.UTF8, "application/json");

}
