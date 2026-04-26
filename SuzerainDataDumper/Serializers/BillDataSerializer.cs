using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class BillDataSerializer : Serializer<BillData>
{
    public BillDataSerializer(BillData obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(BillData))
            .AddProperty(nameof(BillData.AppBundleProperties),
                new AppBundlePropertiesSerializer(Object.AppBundleProperties))
            .AddProperty(nameof(BillData.AssignedTokenProperties),
                new AssignedTokenPropertiesSerializer(Object.AssignedTokenProperties))
            .AddProperty(nameof(BillData.BillProperties),
                new BillPropertiesSerializer(Object.BillProperties))
            .AddProperty(nameof(BillData.NameInDatabase), Object.NameInDatabase)
            .AddProperty(nameof(BillData.StoryFragmentProperties),
                new StoryFragmentPropertiesSerializer(Object.StoryFragmentProperties));
    }
}
