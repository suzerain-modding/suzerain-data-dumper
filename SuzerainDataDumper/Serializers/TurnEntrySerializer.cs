using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class TurnEntrySerializer : Serializer<TurnEntry>
{
    public TurnEntrySerializer(TurnEntry obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(TurnEntry))
            .AddProperty(nameof(TurnEntry.Condition), Object.Condition)
            .AddProperty(nameof(TurnEntry.OnTurnStartInstruction), Object.OnTurnStartInstruction)
            .AddProperty(nameof(TurnEntry.Steps),
                JsonObjectBuilder.FromIl2CppList(Object.Steps,
                    (obj) => new StepEntrySerializer(obj)))
            .AddProperty(nameof(TurnEntry.TransitionTitle), Object.TransitionTitle);
    }
}
