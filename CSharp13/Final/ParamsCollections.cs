using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace CSharp13.Final;

public static class Utils
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

    public static void Concat<T>(params ReadOnlySpan<T> items)
    {
        Console.WriteLine(string.Join(' ', [.. items]));
    }

    [OverloadResolutionPriority(-1)]
    public static void Concat<T>(params ImmutableArray<T> items)
    {
        Console.WriteLine(string.Join(' ', [.. items]));
    }
}
