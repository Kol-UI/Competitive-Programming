Returns the tangent of the specified angle.
```cs
public static class Tan
{
    /// <summary>
    /// Calculates the tangent of an angle (sin/cos).
    /// </summary>
    public static double GetTan(double x)
    {
        // Returns the ratio of Sine to Cosine. Geometrically, it represents 
        // the slope of the line. It becomes undefined (NaN/Infinity) 
        // when Cosine is zero (at 90°, 270°, etc.).

        (double s, double c) = Math.SinCos(x);

        // Division by zero handling (vertical asymptote)
        if (Math.Abs(c) < 1e-15)
        {
            return double.NaN; // Or double.PositiveInfinity depending on the context
        }

        return s / c;
    }

    public static double BuiltInTan(double x) => Math.Tan(x);
}```