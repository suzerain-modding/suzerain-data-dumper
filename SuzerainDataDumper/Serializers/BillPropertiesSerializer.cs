using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class BillPropertiesSerializer : Serializer<BillProperties>
{
    public BillPropertiesSerializer(BillProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(BillProperties))
            .AddProperty(nameof(BillProperties.Description), Object.Description)
            .AddProperty(nameof(BillProperties.HubDescription), Object.HubDescription)
            .AddProperty(nameof(BillProperties.HubTitle), Object.HubTitle)
            .AddProperty(nameof(BillProperties.IsVetoDisabledCondition),
                Object.IsVetoDisabledCondition)
            .AddProperty(nameof(BillProperties.SignVariables), Object.SignVariables)
            .AddProperty(nameof(BillProperties.Title), Object.Title)
            .AddProperty(nameof(BillProperties.VetoVariables), Object.VetoVariables);
    }
}
