using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class NewsPropertiesSerializer : Serializer<NewsProperties>
{
    public NewsPropertiesSerializer(NewsProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(NewsProperties))
            .AddProperty(nameof(NewsProperties.Description), Object.Description)
            .AddProperty(nameof(NewsProperties.Index), Object.Index)
            .AddProperty(nameof(NewsProperties.IsEnabledVariable), Object.IsEnabledVariable)
            .AddProperty(nameof(NewsProperties.Newspaper), Object.Newspaper)
            .AddProperty(nameof(NewsProperties.Title), Object.Title)
            .AddProperty(nameof(NewsProperties.TurnNo), Object.TurnNo);
    }
}
