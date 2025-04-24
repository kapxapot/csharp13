using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CSharp13.Locks;

[MemoryDiagnoser]
public class LockBenchmark
{
    private const int ThreadCount = 1000;
    private const int DepositsPerThread = 1000;
    private const decimal DepositAmount = 1m;

    [Benchmark]
    public decimal BenchmarkNewLock()
    {
        var account = new NewLockAccount();

        Parallel.For(0, ThreadCount, _ =>
        {
            for (int i = 0; i < DepositsPerThread; i++)
            {
                account.Deposit(DepositAmount);
            }
        });

        return account.GetBalance();
    }

    [Benchmark]
    public decimal BenchmarkLightLock()
    {
        var account = new LightLockAccount();

        Parallel.For(0, ThreadCount, _ =>
        {
            for (int i = 0; i < DepositsPerThread; i++)
            {
                account.Deposit(DepositAmount);
            }
        });

        return account.GetBalance();
    }

    [Benchmark]
    public decimal BenchmarkHeavyLock()
    {
        var account = new HeavyLockAccount();

        Parallel.For(0, ThreadCount, _ =>
        {
            for (int i = 0; i < DepositsPerThread; i++)
            {
                account.Deposit(DepositAmount);
            }
        });

        return account.GetBalance();
    }

    public static void Run()
    {
        BenchmarkRunner.Run<LockBenchmark>();
    }
}
