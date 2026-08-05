using Newtonsoft.Json;

namespace Savaged.Core.Extensions;

public static class BuiltInTypesEx
{
    public static string ToBase64(this Stream s)
    {
        if (s is null || s == Stream.Null)
            return string.Empty;
        using var ms = new MemoryStream();
        s.CopyTo(ms);
        return Convert.ToBase64String(ms.ToArray());
    }

    public static string ToJson(this object o) => JsonConvert.SerializeObject(o);

    public static IDictionary<string, object> TryToDictionary(this string json)
    {
        IDictionary<string, object> value;
        try
        {
            value = JsonConvert.DeserializeObject<IDictionary<string, object>>(json);
        }
        catch
        {
            value = new Dictionary<string, object>();
        }
        return value;
    }

}
