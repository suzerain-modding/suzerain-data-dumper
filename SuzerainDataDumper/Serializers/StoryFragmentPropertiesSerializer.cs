using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class StoryFragmentPropertiesSerializer : Serializer<StoryFragmentProperties>
{
    public StoryFragmentPropertiesSerializer(StoryFragmentProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(StoryFragmentProperties))
            .AddProperty(nameof(StoryFragmentProperties.OnStoryFragmentBeginInstruction),
                Object.OnStoryFragmentBeginInstruction)
            .AddProperty(nameof(StoryFragmentProperties.OnStoryFragmentEndInstruction),
                Object.OnStoryFragmentEndInstruction)
            .AddProperty(nameof(StoryFragmentProperties.StoryFragmentCondition),
                Object.StoryFragmentCondition);
    }
}
