namespace CSharp13;

public class Span
{
    public static void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Span<int> span = numbers;
        Span<int> slice = span.Slice(1, 3);

        Console.WriteLine($"Initial array: {string.Join(", ", numbers)}");
        Console.WriteLine($"Span: {string.Join(", ", span.ToArray())}");
        Console.WriteLine($"Slice (1..3): {string.Join(", ", slice.ToArray())}");

        Console.WriteLine();
        Console.WriteLine("Modifying the slice...");

        slice[0] *= 10;
        slice[1] *= 10;
        slice[2] *= 10;

        Console.WriteLine();
        Console.WriteLine($"Resulting array: {string.Join(", ", numbers)}");
        Console.WriteLine($"Span: {string.Join(", ", span.ToArray())}");
        Console.WriteLine($"Slice (1..3): {string.Join(", ", slice.ToArray())}");
    }
}
