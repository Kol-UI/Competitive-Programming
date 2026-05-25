namespace CompetitiveProgramming.Algorithms;
public static class ReciprocalEstimate
{
    /// <summary>
    /// Computes an estimate of the reciprocal (1/x) of a number.
    /// This is designed for high-performance scenarios where speed is prioritized over precision.
    /// </summary>
    public static double GetReciprocalEstimate(double x)
    {
        // 1. Handle special cases
        if (double.IsNaN(x)) return double.NaN;
        if (double.IsInfinity(x)) return 0.0;
        if (x == 0) return double.PositiveInfinity;

        // 2. In a real scenario, this calls a CPU instruction (like RCPSS).
        // For learning, we simulate the 1/x operation.
        // Note: The built-in Math.ReciprocalEstimate might differ slightly 
        // depending on your CPU architecture (Intel vs ARM).
        return 1.0 / x;
    }

    /*
     * Provides a fast approximation of 1/x.
     * It maps to hardware instructions for maximum performance.
     * Warning: The result is less precise than a standard 1.0 / x division.
     */
    public static double BuiltInReciprocalEstimate(double x) => Math.ReciprocalEstimate(x);
}