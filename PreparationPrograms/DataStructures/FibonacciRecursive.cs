namespace PreparationPrograms.DataStructures;

public class FibonacciRecursive
{
    public int GetFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0;
        int b = 1;
        int fib = 0;

        for(int i = 2; i <= n; i++)
        {
            fib = a + b;
            a = b;
            b = fib;
        }

        return fib;
    }
}