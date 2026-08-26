Returns the square root of an int.

```cs
public class SquareRoot
{
    // Approach 1 : Newton's method x = (x + n/x) / 2 until convergence
    public int MySqrtNewton(int n)
    {
        if (n < 2) return n;
        long x = n;
        while (x * x > n)
            x = (x + n / x) / 2;
        return (int)x;
    }

    // Approach 2 : Binary Search - find k such that k² <= n < (k+1)²
    public int MySqrtBinarySearch(int n)
    {
        if (n < 2) return n;
        long low = 1, high = n / 2;
        while (low <= high)
        {
            long mid = low + (high - low) / 2;
            if (mid * mid == n) return (int)mid;
            if (mid * mid < n) low = mid + 1;
            else high = mid - 1;
        }
        return (int)high; // truncated result
    }

    // Approach 3 : Built-in method
    public int MySqrtBuiltIn(int n) => (int)Math.Sqrt(n);
}```