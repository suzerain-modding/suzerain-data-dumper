using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class DecisionPropertiesSerializer : Serializer<DecisionProperties>
{
    public DecisionPropertiesSerializer(DecisionProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(DecisionProperties))
            .AddProperty(nameof(DecisionProperties.Description), Object.Description)
            .AddProperty(nameof(DecisionProperties.HubDescription), Object.HubDescription)
            .AddProperty(nameof(DecisionProperties.HubTitle), Object.HubTitle)
            .AddProperty(nameof(DecisionProperties.Options),
                JsonObjectBuilder.FromIl2CppList(Object.Options,
                    (obj) => new DecisionOptionSerializer(obj)))
            .AddProperty(nameof(DecisionProperties.Title), Object.Title);
    }
}
