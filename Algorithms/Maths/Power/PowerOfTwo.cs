namespace CompetitiveProgramming.Algorithms;

public class PowerOfTwo
{
    // Approach 1 : Bitwise - a power of 2 has exactly one bit set: n & (n-1) clears it
    public bool IsPowerOfTwoBit(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }

    // Approach 2 : Loop - keep dividing by 2; must reach exactly 1
    public bool IsPowerOfTwoLoop(int n)
    {
        if (n <= 0) return false;
        while (n % 2 == 0) n /= 2;
        return n == 1;
    }

    // Approach 3 : Log - must be a whole number
    public bool IsPowerOfTwoLog(int n)
    {
        if (n <= 0) return false;
        double log = Math.Log2(n);
        return Math.Abs(log - Math.Round(log)) < 1e-10;
    }

    // Approach 4 : Built-in method
    public bool IsPowerOfTwoBuiltIn(int n) => int.IsPow2(n);
}