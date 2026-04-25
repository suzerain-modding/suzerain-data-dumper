using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class AssignedTokenPropertiesSerializer : Serializer<AssignedTokenProperties>
{
    public AssignedTokenPropertiesSerializer(AssignedTokenProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(AssignedTokenProperties))
            .AddProperty(nameof(AssignedTokenProperties.AssignedToken), Object.AssignedToken);
    }
}
