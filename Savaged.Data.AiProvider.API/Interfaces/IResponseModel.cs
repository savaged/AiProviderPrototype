namespace Savaged.Data.AiProvider.API.Interfaces;

public interface IResponseModel
{
    string result { get; }
    string request_id { get; }
    string data { get; }
}
