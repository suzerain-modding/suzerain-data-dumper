using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class AppBundlePropertiesSerializer : Serializer<AppBundleProperties>
{
    public AppBundlePropertiesSerializer(AppBundleProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(AppBundleProperties))
            .AddProperty(nameof(AppBundleProperties.AppBundle), Object.AppBundle)
            .AddProperty(nameof(AppBundleProperties.StoryPacks),
                JsonObjectBuilder.FromIl2CppList(Object.StoryPacks));
    }
}
