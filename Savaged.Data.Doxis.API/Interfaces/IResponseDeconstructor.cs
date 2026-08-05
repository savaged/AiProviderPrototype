namespace Savaged.Data.Doxis.API.Interfaces;

public interface IResponseDeconstructor
{
    object Deconstruct(string response);
}
