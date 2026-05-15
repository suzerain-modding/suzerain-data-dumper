using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class NewsDataSerializer : Serializer<NewsData>
{
    public NewsDataSerializer(NewsData obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(NewsData))
            .AddProperty(nameof(NewsData.AppBundleProperties),
                new AppBundlePropertiesSerializer(Object.AppBundleProperties))
            .AddProperty(nameof(NewsData.NameInDatabase), Object.NameInDatabase)
            .AddProperty(nameof(NewsData.NewsProperties),
                new NewsPropertiesSerializer(Object.NewsProperties))
            .AddProperty(nameof(NewsData.Path), Object.Path);
    }
}
