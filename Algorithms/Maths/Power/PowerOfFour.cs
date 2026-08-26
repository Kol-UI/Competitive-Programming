namespace CompetitiveProgramming.Algorithms;

public class PowerOfFour
{
    // Approach 1 : Loop - keep dividing by 4; must reach exactly 1
    public bool IsPowerOfFourLoop(int n)
    {
        if (n <= 0) return false;
        while (n % 4 == 0) n /= 4;
        return n == 1;
    }

    // Approach 2 : Log - must be a whole number (floating point tolerance required)
    public bool IsPowerOfFourLog(int n)
    {
        if (n <= 0) return false;
        double log = Math.Log(n, 4);
        return Math.Abs(log - Math.Round(log)) < 1e-10;
    }

    // Approach 3 : Math Trick - 4^15 = 1073741824 is the largest power of 4 in int range
    public bool IsPowerOfFourMath(int n)
    {
        return n > 0 && 1073741824 % n == 0 && (n & 0xAAAAAAAA) == 0;
    }

    // Approach 4 : Bitwise - powers of 4 are powers of 2 whose single set bit is at an even index;
    // 0xAAAAAAAA masks all odd-index bits, so ANDing must give 0
    public bool IsPowerOfFourBit(int n)
    {
        return n > 0 && (n & (n - 1)) == 0 && (n & 0xAAAAAAAA) == 0;
    }

    // Approach 5 : Recursive - recurse down by dividing by 4 until base case
    public bool IsPowerOfFourRecursive(int n)
    {
        if (n == 1) return true;
        if (n <= 0 || n % 4 != 0) return false;
        return IsPowerOfFourRecursive(n / 4);
    }
}