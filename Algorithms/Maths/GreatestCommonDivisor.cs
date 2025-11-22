namespace CompetitiveProgramming.Algorithms;

public class GreatestCommonDivisor()
{
    // Euclidean Algorithm
    public static int GetGCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0 && b == 0) return 0;

        while (a > 0 && b > 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }
        if (a == 0) return b;
        return a;
    }
}