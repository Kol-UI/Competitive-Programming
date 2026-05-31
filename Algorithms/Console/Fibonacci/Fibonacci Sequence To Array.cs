namespace CompetitiveProgramming.Algorithms;
public class FibonacciSequenceToArray
{
    public static long[] Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be positive");
        if (n == 0) return [0];
        
        long[] sequence = new long[n + 1];
        sequence[0] = 0;
        sequence[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }

        return sequence;
    }
}