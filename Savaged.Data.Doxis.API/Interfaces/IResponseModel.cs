namespace Savaged.Data.Doxis.API.Interfaces;

public interface IResponseModel
{
    string result { get; }
    string request_id { get; }
    object data { get; }
}
