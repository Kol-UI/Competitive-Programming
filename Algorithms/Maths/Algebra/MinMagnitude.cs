namespace CompetitiveProgramming.Algorithms;
public static class MinMagnitude
{
    /// <summary>
    /// Returns the value with the smallest magnitude (absolute value).
    /// If magnitudes are equal, it returns the algebraically smaller value.
    /// </summary>
    public static double GetMinMagnitude(double x, double y)
    {
        // 1. Get the absolute values (magnitudes)
        double absX = Math.Abs(x);
        double absY = Math.Abs(y);

        // 2. Compare magnitudes
        if (absX < absY)
        {
            return x;
        }
        if (absY < absX)
        {
            return y;
        }

        // 3. If magnitudes are equal (e.g., 5 and -5), return the smaller value (-5)
        // This follows the IEEE 754 specification.
        return x < y ? x : y;
    }

    /*
     * Returns the number with the smallest absolute value (closest to zero).
     * If magnitudes are identical (e.g., -5 and 5), it returns the smaller one (-5).
     * Unlike Math.Min, it focuses on the distance from zero.
     */
    public static double BuiltInMinMagnitude(double x, double y) => Math.MinMagnitude(x, y);
}