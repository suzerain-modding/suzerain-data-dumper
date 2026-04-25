namespace SuzerainDataDumper;

internal static class Utils
{
    public static List<T> ListFromIl2CppList<T>(Il2CppSystem.Collections.Generic.List<T> il2CppList)
    {
        List<T> list = [];
        foreach (T v in il2CppList)
        {
            list.Add(v);
        }
        return list;
    }
}
