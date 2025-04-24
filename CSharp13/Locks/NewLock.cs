namespace CSharp13.Locks;

public class NewLockAccount
{
    // new Lock object
    private readonly Lock _lockObj = new();
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
