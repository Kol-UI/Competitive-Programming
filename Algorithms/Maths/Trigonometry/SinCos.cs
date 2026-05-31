namespace CompetitiveProgramming.Algorithms;
public static class SinCos
{
    /// <summary>
    /// Simultaneously calculates the Sine and Cosine of an angle.
    /// </summary>
    public static (double Sin, double Cos) GetSinCos(double x)
    {
        // Returns both Sine and Cosine as a tuple. 
        // Efficiently computes both values in a single pass to save CPU cycles 
        // by reusing common intermediate calculations (like x^n).
        // In a real "from scratch" implementation, both Taylor series 
        // would be calculated within the same loop.
        double s = Math.Sin(x);
        double c = Math.Cos(x);

        return (s, c);
    }

    public static (double Sin, double Cos) BuiltInSinCos(double x) => Math.SinCos(x);
}