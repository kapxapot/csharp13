namespace CSharp13.Locks;

public class LightLockAccount
{
    // Lightweight lock object (empty object)
    private readonly object _lockObj = new object();
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
