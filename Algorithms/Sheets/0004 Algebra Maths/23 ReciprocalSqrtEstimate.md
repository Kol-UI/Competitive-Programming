Returns an estimate of the reciprocal square root of a specified number.
```cs
public static class ReciprocalSqrtEstimate
{
    /// <summary>
    /// Computes an estimate of the reciprocal square root (1 / sqrt(x)).
    /// Highly optimized for 3D graphics and vector normalization.
    /// </summary>
    public static double GetReciprocalSqrtEstimate(double x)
    {
        // 1. Handle special cases
        if (x < 0 || double.IsNaN(x)) return double.NaN;
        if (x == 0) return double.PositiveInfinity;
        if (double.IsInfinity(x)) return 0.0;

        // 2. Simulation of the 1 / sqrt(x) operation.
        // In .NET, the built-in method uses a direct CPU instruction.
        return 1.0 / Math.Sqrt(x);
    }

    /*
     * Provides a fast approximation of 1 / sqrt(x).
     * Essential for normalizing vectors in 3D graphics.
     * Uses hardware acceleration (like RSQRTSS) for near-instant results.
     */
    public static double BuiltInReciprocalSqrtEstimate(double x) => Math.ReciprocalSqrtEstimate(x);
}```