namespace CompetitiveProgramming.Algorithms;
public static class Atanh
{
    public static double GetAtanh(double x)
    {
        // atanh(x) = 0.5 * ln((1 + x) / (1 - x)). Defined only for |x| < 1.
        if (x <= -1.0 || x >= 1.0) return double.NaN;
        return 0.5 * Math.Log((1.0 + x) / (1.0 - x));
    }

    public static double BuiltInAtanh(double d)
    {
        // Returns the inverse hyperbolic tangent of the specified number.
        return Math.Atanh(d);
    }
}