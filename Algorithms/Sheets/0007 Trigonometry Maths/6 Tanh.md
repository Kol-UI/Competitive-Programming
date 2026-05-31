Returns the hyperbolic tangent of the specified angle.
```cs
public static class Tanh
{
    /// <summary>
    /// Calculates the hyperbolic tangent of a number.
    /// </summary>
    public static double GetTanh(double x)
    {
        /* * Tanh implementation: (e^x - e^-x) / (e^x + e^-x)
         * Returns a value between -1 and 1.
         * Symmetric around zero: Tanh(-x) = -Tanh(x).
         * As x approaches infinity, result approaches 1.
         * As x approaches -infinity, result approaches -1.
         */
        
        double expPos = Math.Exp(x);
        double expNeg = Math.Exp(-x);

        return (expPos - expNeg) / (expPos + expNeg);
    }

    public static double BuiltInTanh(double x) => Math.Tanh(x);
}```