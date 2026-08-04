using System.Threading.Tasks;

namespace Savaged.Data.Doxis.API.Interfaces;

public interface IBodyBuilder
{
    Task<string> BuildAsync(string input);
}
