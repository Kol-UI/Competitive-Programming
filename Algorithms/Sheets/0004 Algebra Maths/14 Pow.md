Returns a specified number raised to the specified power.
```cs
public static class Pow
{
    /// <summary>
    /// Computes the power of a number. 
    /// Uses fast exponentiation for integers and the Exp(y * Ln(x)) identity for decimals.
    /// </summary>
    public static double GetPow(double x, double y)
    {
        // 1. Basic special cases
        if (y == 0) return 1.0;
        if (double.IsNaN(x) || double.IsNaN(y)) return double.NaN;
        if (x == 1.0) return 1.0;
        if (x == 0) return y > 0 ? 0 : double.PositiveInfinity;

        // 2. If the exponent is an integer (classic optimization)
        if (y % 1 == 0)
        {
            return PowerInt(x, (long)y);
        }

        // 3. If the base is negative with a fractional exponent -> Undefined for real numbers
        if (x < 0) return double.NaN;

        // 4. Calculation for fractional exponent: x^y = exp(y * ln(x))
        return Math.Exp(y * Math.Log(x));
    }

    private static double PowerInt(double x, long y)
    {
        if (y < 0) return 1.0 / PowerInt(x, -y);

        double result = 1.0;
        while (y > 0)
        {
            if ((y & 1) == 1) result *= x; // If y is odd
            x *= x;
            y >>= 1; // Division by 2 (bitwise shift)
        }
        return result;
    }

    /*
     * Computes x raised to the power y.
     * Uses Fast Exponentiation (binary exponentiation) for integer powers.
     * Uses the identity e^(y * ln(x)) for fractional powers.
     * Handles negative bases and fractional exponents by returning NaN.
     */
    public static double BuiltInPow(double x, double y) => Math.Pow(x, y);
}```