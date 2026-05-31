namespace CompetitiveProgramming.Algorithms;
public class FibonacciIterative
{
    public static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be positive");
        if (n <= 1) return n;

        long prev = 0, curr = 1;

        for (int i = 2; i <= n; i++)
        {
            long next = prev + curr;
            prev = curr;
            curr = next;
        }

        return curr;
    }
}