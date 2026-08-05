using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.Doxis.API.Client;

public class SaveToStorageResponseDeconstructor : IResponseDeconstructor
{
    public async IResponseModel Deconstruct(string response)
    {
        var dict = response.TryToDictionary();
    }
}
