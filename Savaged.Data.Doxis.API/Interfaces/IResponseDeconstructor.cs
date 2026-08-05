namespace Savaged.Data.Doxis.API.Interfaces;

public interface IResponseDeconstructor
{
    IResponseModel Deconstruct(string response);
}
