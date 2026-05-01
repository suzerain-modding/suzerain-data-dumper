using DecisionOption = Il2Cpp.DecisionProperties.DecisionOption;

namespace SuzerainDataDumper.Serializers;

internal sealed class DecisionOptionSerializer : Serializer<DecisionOption>
{
    public DecisionOptionSerializer(DecisionOption obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(DecisionOption))
            .AddProperty(nameof(DecisionOption.Condition), Object.Condition)
            .AddProperty(nameof(DecisionOption.Instruction), Object.Instruction)
            .AddProperty(nameof(DecisionOption.Text), Object.Text);
    }
}
