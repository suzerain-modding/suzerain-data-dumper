using Il2CppPixelCrushers.DialogueSystem;

namespace SuzerainDataDumper.Serializers;

internal sealed class FieldSerializer : Serializer<Field>
{
    public FieldSerializer(Field obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(Field))
            .AddProperty(nameof(Field.title), Object.title)
            .AddProperty(nameof(Field.typeString), Object.typeString)
            .AddProperty(nameof(Field.value), Object.value);
    }
}
