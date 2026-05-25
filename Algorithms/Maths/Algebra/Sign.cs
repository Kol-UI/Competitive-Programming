namespace CompetitiveProgramming.Algorithms;
public static class Sign
{
    public static int GetSign(double d)
    {
        // Returns 1, 0, or -1 based on the polarity of the input.
        if (d > 0) return 1;
        if (d < 0) return -1;
        return 0;
    }

    public static int BuiltInSign(double d) => Math.Sign(d);
}