namespace CompetitiveProgramming.Algorithms;
public class Acosh
{
    public static double GetAcosh(double x)
    {
        // acosh(x) = ln(x + sqrt(x^2 - 1)). Only defined for x >= 1.
        if (x < 1.0) return double.NaN;

        return Math.Log(x + Math.Sqrt(x * x - 1.0));
    }

    public static double BuiltInAcosh(double x) => Math.Acosh(x);
}