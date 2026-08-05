namespace Savaged.Data.Doxis.API.Interfaces;

public interface IDoxisClient
{
    Task<HttpResponseMessage> GetResponseAsync(HttpVerb verb, string endPoint, string body = "");
}
