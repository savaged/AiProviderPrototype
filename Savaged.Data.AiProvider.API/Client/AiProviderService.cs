using Savaged.Data.AiProvider.API.Interfaces;

namespace Savaged.Data.AiProvider.API.Client;

public class AiProviderService : IAiProviderService
{
    private readonly IAiProviderClient _doxisClient;

    public AiProviderService(IAiProviderClient doxisClient, string endPoint, HttpVerb verb = HttpVerb.POST)
    {
        _doxisClient = doxisClient;
        EndPoint = endPoint;
        Verb = verb;
    }

    public string EndPoint { get; }

    public HttpVerb Verb { get; }

    public async Task<string> EnactAsync(string body = "")
    {
        var response = await _doxisClient.GetResponseAsync(Verb, EndPoint, body);
        if (!response.IsSuccessStatusCode)
            return response.StatusCode.ToString();
        return await response.Content.ReadAsStringAsync();
    }

}
