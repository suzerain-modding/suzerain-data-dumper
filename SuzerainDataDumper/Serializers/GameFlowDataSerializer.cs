using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class GameFlowDataSerializer : Serializer<GameFlowData>
{
    public GameFlowDataSerializer(GameFlowData obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(GameFlowData))
            .AddProperty(nameof(GameFlowData.Description), Object.Description)
            .AddProperty(nameof(GameFlowData.Path), Object.Path)
            .AddProperty(nameof(GameFlowData.StoryPack), Object.StoryPack)
            .AddProperty(nameof(GameFlowData.Turns),
                JsonObjectBuilder.FromIl2CppList(Object.Turns,
                    (obj) => new TurnEntrySerializer(obj)));
    }
}
