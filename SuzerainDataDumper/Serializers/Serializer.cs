namespace SuzerainDataDumper.Serializers;

internal abstract class Serializer<T>
{
    protected T Object
    {
        get; init;
    }

    protected Serializer(T obj)
    {
        Object = obj ?? throw new ArgumentNullException(nameof(obj));
    }

    public string Serialize()
    {
        return ToJsonObjectBuilder().ToString();
    }

    protected abstract JsonObjectBuilder ToJsonObjectBuilder();
}
