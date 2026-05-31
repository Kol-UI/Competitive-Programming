Write a function that calculates the nth term of the Fibonacci sequence using a memoization approach.
```cs
public class FibonacciMemoization
{
    // Check if result is already in cache
    private static readonly Dictionary<int, long> _cache = new();

    public static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be positive");
        if (n <= 1) return n;
        if (_cache.TryGetValue(n, out long cached)) return cached;

        long result = Fibonacci(n - 1) + Fibonacci(n - 2);
        _cache[n] = result;

        return result;
    }

    public static void ClearCache() => _cache.Clear();
}```