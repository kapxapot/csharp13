using System.Collections.Immutable;

namespace CSharp13;

public class Immutable
{
    public static void Run()
    {
        // no constructors
        // use Empty or Create to create new collection

        var numbers = ImmutableArray.Create<int>(1, 2, 3, 4, "a");
        Console.WriteLine("Original array: " + string.Join(", ", numbers));

        var moreNumbers = numbers.Add(6);
        Console.WriteLine();
        Console.WriteLine("After Add: " + string.Join(", ", moreNumbers));
        Console.WriteLine("Original remains: " + string.Join(", ", numbers));

        var lessNumbers = moreNumbers.RemoveAt(2);
        Console.WriteLine();
        Console.WriteLine("After Remove: " + string.Join(", ", lessNumbers));
        Console.WriteLine("Original remains: " + string.Join(", ", numbers));
    }
}
