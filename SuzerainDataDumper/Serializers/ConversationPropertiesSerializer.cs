using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class ConversationPropertiesSerializer : Serializer<ConversationProperties>
{
    public ConversationPropertiesSerializer(ConversationProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(ConversationProperties))
            .AddProperty(nameof(ConversationProperties.Dialogue), Object.Dialogue)
            .AddProperty(nameof(ConversationProperties.IsOnStart), Object.IsOnStart)
            .AddProperty(nameof(ConversationProperties.Subtitle), Object.Subtitle)
            .AddProperty(nameof(ConversationProperties.Title), Object.Title)
            .AddProperty(nameof(ConversationProperties.TypeString), Object.TypeString);
    }
}
