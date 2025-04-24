namespace CSharp13;

public class NewLockExample
{
    private readonly Lock _lockObj = new Lock();
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
