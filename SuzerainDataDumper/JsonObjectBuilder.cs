using System.Globalization;
using System.Text;
using System.Text.Json;
using SuzerainDataDumper.Serializers;

namespace SuzerainDataDumper;

internal sealed class JsonObjectBuilder
{
    public string TypeName
    {
        get; set;
    }
    public Dictionary<string, string> StrProperties
    {
        get; set;
    } = [];

    public JsonObjectBuilder(string typeName)
    {
        TypeName = typeName ?? "<null>";
    }

    public JsonObjectBuilder AddPropertyRaw(string name, string rawValue)
    {
        StrProperties[name] = rawValue;
        return this;
    }

    public JsonObjectBuilder AddProperty(string name, JsonObjectBuilder builder)
    {
        return AddPropertyRaw(name, builder.ToString());
    }

    public JsonObjectBuilder AddProperty<T>(string name, Serializer<T> serializer)
    {
        return AddPropertyRaw(name, serializer.Serialize());
    }

    public JsonObjectBuilder AddProperty(string name, object value)
    {
        string rawValue;
        try
        {
            rawValue = JsonSerializer.Serialize(value);
        }
        catch
        {
            rawValue = "\"<error>\"";
        }
        return AddPropertyRaw(name, rawValue);
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append('{');
        foreach (KeyValuePair<string, string> property in StrProperties)
        {
            sb.Append(CultureInfo.InvariantCulture, $"\"{property.Key}\":{property.Value},");
        }
        sb.Append(CultureInfo.InvariantCulture, $"\"_type\":\"{TypeName}\"}}");

        return sb.ToString();
    }

    public static JsonObjectBuilder FromList<T>(IList<T> list)
    {
        JsonObjectBuilder builder = new($"List<{typeof(T).Name}>");
        for (int i = 0; i < list.Count; i++)
        {
            _ = builder.AddProperty(i.ToString(CultureInfo.InvariantCulture), list[i]);
        }
        return builder;
    }

    public static JsonObjectBuilder FromList<T>(
        IList<T> list,
        Func<T, Serializer<T>> serializerFactory)
    {
        JsonObjectBuilder builder = new($"List<{typeof(T).Name}>");
        for (int i = 0; i < list.Count; i++)
        {
            Serializer<T> serializer = serializerFactory(list[i]);
            _ = builder.AddProperty(i.ToString(CultureInfo.InvariantCulture), serializer);
        }
        return builder;
    }

    public static JsonObjectBuilder FromIl2CppList<T>(
        Il2CppSystem.Collections.Generic.List<T> list)
    {
        JsonObjectBuilder builder = new($"List<{typeof(T).Name}>");
        for (int i = 0; i < list.Count; i++)
        {
            _ = builder.AddProperty(i.ToString(CultureInfo.InvariantCulture), list[i]);
        }
        return builder;
    }

    public static JsonObjectBuilder FromIl2CppList<T>(
        Il2CppSystem.Collections.Generic.List<T> list,
        Func<T, Serializer<T>> serializerFactory)
    {
        JsonObjectBuilder builder = new($"List<{typeof(T).Name}>");
        for (int i = 0; i < list.Count; i++)
        {
            Serializer<T> serializer = serializerFactory(list[i]);
            _ = builder.AddProperty(i.ToString(CultureInfo.InvariantCulture), serializer);
        }
        return builder;
    }
}

