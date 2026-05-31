Create a function that returns True when a number is Fibonacci
```cs
public class FibonacciCheckeIfNumberIsFibonacci
{
    public static bool IsFibonacci(long n)
    {
        if (n < 0) return false;

        return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
    }

    /* Gessel's Theorem :
    * A number 'n' belongs to the Fibonacci sequence IF AND ONLY IF one of the 
    * following two numbers is a perfect square:
    * * 5 * n² + 4
    * OR
    * 5 * n² - 4
    * * A perfect square is simply a number whose square root is an integer 
    * (such as 9, 16, 25, 121, etc...).
    */
    private static bool IsPerfectSquare(long n)
    {
        if (n < 0) return false;
        long sqrt = (long)Math.Sqrt(n);
        return sqrt * sqrt == n;
    }
}```