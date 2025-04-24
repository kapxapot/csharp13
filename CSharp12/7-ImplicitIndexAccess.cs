namespace CSharp13;

public class TimerRemaining
{
    public int[] Buffer { get; set; } = new int[5];

    public static void Test()
    {
        // ascending order
        // gives ['a', 'b', 'c', 'd', 'e']
        var countup = new TimerRemaining()
        {
            Buffer =
            {
                [0] = 'a',
                [1] = 'b',
                [2] = 'c',
                [3] = 'd',
                [4] = 'e'
            }
        };

        // descending order
        // gives ['e', 'd', 'c', 'b', 'a']
        var countdown = new TimerRemaining()
        {
            Buffer =
            {
                [^1] = 'a', // same as [Count - 1] => [4]
                [^2] = 'b', // same as [Count - 2] => [3]
                [^3] = 'c', // same as [Count - 3] => [2]
                [^4] = 'd', // same as [Count - 4] => [1]
                [^5] = 'e'  // same as [Count - 5] => [0]
            }
        };
    }
}
