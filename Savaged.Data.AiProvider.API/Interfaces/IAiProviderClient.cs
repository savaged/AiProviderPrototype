namespace Savaged.Data.AiProvider.API.Interfaces;

public interface IAiProviderClient
{
    Task<HttpResponseMessage> GetResponseAsync(HttpVerb verb, string endPoint, string body = "");
}
