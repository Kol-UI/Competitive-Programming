namespace CompetitiveProgramming.Algorithms;
public static class Truncate
{
    public static double GetTruncate(double d)
    {
        // Simply removes decimal digits, effectively rounding towards zero.
        // Equivalent to casting to an integer type.
        return (double)(long)d;
    }

    public static double BuiltInTruncate(double d) => Math.Truncate(d);
}