using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Prac.Serialize;
public static class Serialize
{
    public static string ToJson<T>(this T obj)
    {
        return JsonConvert.SerializeObject(obj);
    }

    public static T FromJson<T>(this string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}
