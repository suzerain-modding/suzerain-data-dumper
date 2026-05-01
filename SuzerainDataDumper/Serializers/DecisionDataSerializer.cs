using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class DecisionDataSerializer : Serializer<DecisionData>
{
    public DecisionDataSerializer(DecisionData obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(DecisionData))
            .AddProperty(nameof(DecisionData.AppBundleProperties),
                new AppBundlePropertiesSerializer(Object.AppBundleProperties))
            .AddProperty(nameof(DecisionData.AssignedTokenProperties),
                new AssignedTokenPropertiesSerializer(Object.AssignedTokenProperties))
            .AddProperty(nameof(DecisionData.DecisionProperties),
                new DecisionPropertiesSerializer(Object.DecisionProperties))
            .AddProperty(nameof(DecisionData.NameInDatabase), Object.NameInDatabase)
            .AddProperty(nameof(DecisionData.StoryFragmentProperties),
                new StoryFragmentPropertiesSerializer(Object.StoryFragmentProperties));
    }
}
