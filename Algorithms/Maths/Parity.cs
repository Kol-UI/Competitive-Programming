namespace CompetitiveProgramming.Algorithms;

public class Parity
{
    // return true if both even or both odd
    public static bool HasSameParity(int a, int b)
    {
        return (a % 2) == (b % 2);
    }
}