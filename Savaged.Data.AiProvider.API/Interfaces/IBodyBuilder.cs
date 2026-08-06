namespace Savaged.Data.AiProvider.API.Interfaces;

public interface IBodyBuilder
{
    Task<string> BuildAsync(string input);
}
