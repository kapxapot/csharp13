using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace CSharp13;

public static class ParamCollections
{
    public static void Test()
    {
        Concat(1, 2, 3);
        Concat([4, 5, 6]);
    }

    [OverloadResolutionPriority(-1)]
    public static void Concat<T>(params T[] items)
    {
        Console.WriteLine("array");
        Console.WriteLine(string.Join(' ', items));
    }

    public static void Concat<T>(params IEnumerable<T> items)
    {
        Console.WriteLine("ienumerable");
        Console.WriteLine(string.Join(' ', items));
    }

    [OverloadResolutionPriority(-1)]
    public static void Concat<T>(params ReadOnlySpan<T> items)
    {
        Console.WriteLine("span");
        Console.WriteLine(string.Join(' ', items.ToArray()));
    }

    public static void Concat<T>(params ImmutableArray<T> items)
    {
        Console.WriteLine("immutablearray");
        Console.WriteLine(string.Join(' ', items));
    }
}
