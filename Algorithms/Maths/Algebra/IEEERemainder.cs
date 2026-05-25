namespace CompetitiveProgramming.Algorithms;
public static class IEEERemainder
{
    /// <summary>
    /// Computes the remainder as defined by the IEEE 754 standard.
    /// Unlike the % operator, it finds the nearest integer to the quotient (rounding to even if .5).
    /// </summary>
    public static double GetIEEERemainder(double x, double y)
    {
        // Handle error cases (division by zero or invalid inputs)
        if (double.IsNaN(x) || double.IsNaN(y) || double.IsInfinity(x) || y == 0)
            return double.NaN;
        
        if (double.IsInfinity(y))
            return x;

        // 1. Calculate the real quotient
        double quotient = x / y;

        // 2. Round to the nearest integer.
        // If it's exactly halfway (e.g., 2.5), round to the nearest EVEN integer.
        double n = Math.Round(quotient, MidpointRounding.ToEven);

        // 3. Formula: Remainder = Dividend - (RoundedQuotient * Divisor)
        return x - (n * y);
    }

    /*
     * Computes the remainder as defined by IEEE 754.
     * Logic: x - (y * n) where 'n' is the integer nearest to x/y.
     * Uses "Round to nearest, ties to even" for n.
     * Different from % which truncates the quotient toward zero.
     */
    public static double BuiltInIEEERemainder(double x, double y) => Math.IEEERemainder(x, y);
}