Returns the larger magnitude of two double-precision floating-point numbers. Magnitude = distance to 0. Also when magnitude is egal, return the positive value.
```cs
public static class MaxMagnitude
{
    /// <summary>
    /// Returns the value with the largest magnitude (absolute value).
    /// If magnitudes are equal, it returns the algebraically larger value.
    /// </summary>
    public static double GetMaxMagnitude(double x, double y)
    {
        // 1. Get the absolute values (magnitudes)
        double absX = Math.Abs(x);
        double absY = Math.Abs(y);

        // 2. Compare magnitudes
        if (absX > absY)
        {
            return x;
        }
        if (absY > absX)
        {
            return y;
        }

        // 3. If magnitudes are equal, return the larger of the two values
        // This handles cases like (5, -5) where we return 5.
        // It also handles NaN correctly via the built-in comparison rules.
        return x > y ? x : y;
    }

    /*
     * Returns the number with the greatest absolute value.
     * If magnitudes are identical (e.g., -5 and 5), it returns the larger one (5).
     * Different from Math.Max which focuses on the algebraic value.
     */
    public static double BuiltInMaxMagnitude(double x, double y) => Math.MaxMagnitude(x, y);
}```