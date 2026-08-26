Determine if an int is a power of 3.

```cs
public class PowerOfThree
{
    // Approach 1 : Loop - keep dividing by 3; must reach exactly 1
    public bool IsPowerOfThreeLoop(int n)
    {
        if (n <= 0) return false;
        while (n % 3 == 0) n /= 3;
        return n == 1;
    }

    // Approach 2 : Log - must be a whole number (floating point tolerance required)
    public bool IsPowerOfThreeLog(int n)
    {
        if (n <= 0) return false;
        double log = Math.Log(n, 3);
        return Math.Abs(log - Math.Round(log)) < 1e-10;
    }

    // Approach 3 : Math Trick - 3^19 = 1162261467 is the largest power of 3 in int range;
    // any power of 3 must divide it evenly
    public bool IsPowerOfThreeMath(int n)
    {
        return n > 0 && 1162261467 % n == 0;
    }

    // Approach 4 : Recursive - recurse down by dividing by 3 until base case
    public bool IsPowerOfThreeRecursive(int n)
    {
        if (n == 1) return true;
        if (n <= 0 || n % 3 != 0) return false;
        return IsPowerOfThreeRecursive(n / 3);
    }
}```