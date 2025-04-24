namespace CSharp13.Locks;

// This "heavy" object has several extra fields.
public class HeavyLock
{
    // Dummy fields to simulate additional memory footprint.
    private int[] ints = new int[1000];

    public HeavyLock()
    {
        // Initialize the dummy fields.
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = i;
        }
    }
}

public class HeavyLockAccount
{
    // Lock using a heavy object
    private readonly HeavyLock _lockObj = new HeavyLock();
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        lock (_lockObj)
        {
            _balance += amount;
        }
    }

    public decimal GetBalance()
    {
        lock (_lockObj)
        {
            return _balance;
        }
    }
}
