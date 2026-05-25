namespace CompetitiveProgramming.Algorithms;
public static class Log10
{
    /// <summary>
    /// Calculate Log Base 10
    /// Formula : ln(x) / ln(10)
    /// </summary>
    public static double GetLog10(double x)
    {
        if (x <= 0) return double.NaN;
        if (x == 0) return double.NegativeInfinity;
        return Math.Log(x) / Math.Log(10.0);
    }

    public static double BuiltInLog10(double d) => Math.Log10(d);
}