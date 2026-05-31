Returns the hyperbolic cosine of the specified angle.
```cs
public static class Cosh
{
    /// <summary>
    /// Returns the hyperbolic cosine of the specified angle.
    /// </summary>
    public static double GetCosh(double x)
    {
        // Uses the exponential definition: cosh(x) = (e^x + e^-x) / 2
        return (Math.Exp(x) + Math.Exp(-x)) / 2.0;
    }

    public static double BuiltInCosh(double x) => Math.Cosh(x);
}```