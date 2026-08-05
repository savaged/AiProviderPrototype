using Savaged.Data.Doxis.API.Interfaces;
using Savaged.Data.Doxis.API.Models;
using Savaged.Core.Extensions;

namespace Savaged.Data.Doxis.API.Client;

public class SaveToStorageResponseDeconstructor : IResponseDeconstructor
{
    public object Deconstruct(string response)
    {
        var dict = response.TryToDictionary();
        var key = nameof(IResponseModel.data);
        var data = dict?.ContainsKey(key) == true ? dict[key].ToString() : string.Empty;
        dict = data?.TryToDictionary() ?? new Dictionary<string, object>();
        key = nameof(Document.file_id);
        return dict?.ContainsKey(key) == true ? dict[key] : string.Empty;
    }
}
