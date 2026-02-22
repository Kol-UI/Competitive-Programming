namespace CompetitiveProgramming.Algorithms.Maths;
public class LeastCommonMutiple
{
    public long GetLCM(long a, long b)
    {
        if (a == 0 || b == 0) return 0;
        return Math.Abs(a / GreatestCommonDivisor.GetGCD((int)a, (int)b) * b);
    }
}