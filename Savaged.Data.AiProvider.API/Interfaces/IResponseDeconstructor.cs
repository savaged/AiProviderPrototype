namespace Savaged.Data.AiProvider.API.Interfaces;

public interface IResponseDeconstructor
{
    object Deconstruct(string response);
}
