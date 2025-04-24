namespace CSharp12;

public static class ParamCollections
{
    public static void Test()
    {
        Concat(1, 2, 3);
        Concat([4, 5, 6]);
    }

    public static void Concat<T>(params T[] items)
    {
        Console.WriteLine(string.Join(' ', items));
    }

    public static void Concat<T>(params IEnumerable<T> items)
    {
        Console.WriteLine(string.Join(' ', items));
    }
}
