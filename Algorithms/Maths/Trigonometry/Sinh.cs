namespace CompetitiveProgramming.Algorithms;
public static class Sinh
{
    /// <summary>
    /// Calculates the hyperbolic sine of x.
    /// </summary>
    public static double GetSinh(double x)
    {
        // Computes the hyperbolic sine using the formula: (e^x - e^-x) / 2.
        // Unlike circular sine, it grows exponentially and relates to 
        // hyperbolic geometry and physical curves like hanging cables.

        // Direct formula: (exp(x) - exp(-x)) / 2
        return (Math.Exp(x) - Math.Exp(-x)) / 2.0;
    }

    public static double BuiltInSinh(double x) => Math.Sinh(x);
}