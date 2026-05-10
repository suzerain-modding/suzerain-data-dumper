using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class ConversationDataSerializer : Serializer<ConversationData>
{
    public ConversationDataSerializer(ConversationData obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(ConversationData))
            .AddProperty(nameof(ConversationData.AppBundleProperties),
                new AppBundlePropertiesSerializer(Object.AppBundleProperties))
            .AddProperty(nameof(ConversationData.AssignedTokenProperties),
                new AssignedTokenPropertiesSerializer(Object.AssignedTokenProperties))
            .AddProperty(nameof(ConversationData.ConversationProperties),
                new ConversationPropertiesSerializer(Object.ConversationProperties))
            .AddProperty(nameof(ConversationData.NameInDatabase), Object.NameInDatabase)
            .AddProperty(nameof(ConversationData.Path), Object.Path)
            .AddProperty(nameof(ConversationData.StoryFragmentProperties),
                new StoryFragmentPropertiesSerializer(Object.StoryFragmentProperties));
    }
}
