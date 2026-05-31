namespace CompetitiveProgramming.Algorithms;
public class FibonacciRecursive
{
    public static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be positive");
        if (n <= 1) return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}