Returns the sine of the specified angle.
```cs
public static class Sin
{
    /// <summary>
    /// Calculates the sine of an angle in radians using the Taylor series.
    /// </summary>
    public static double GetSin(double x)
    {
        // Computes sin(x) using the Taylor series expansion.
        // It reduces x to the range [-PI, PI] and sums polynomial terms 
        // (x^n / n!) with alternating signs to approximate the value.

        // 1. Reduce the interval to [-PI, PI]
        x = x % (2 * Math.PI);
        if (x > Math.PI) x -= 2 * Math.PI;
        if (x < -Math.PI) x += 2 * Math.PI;

        double result = 0;
        double term = x; // First term of the series (x^1 / 1!)
        double xSquared = x * x;

        // 2. Sum the first 10 terms of the series (looping up to 20 for odd exponents)
        for (int i = 1; i <= 20; i += 2)
        {
            result += term;
            // Calculate the next term: - (term * x^2) / ((i+1) * (i+2))
            // This avoids calculating giant factorials separately
            term *= -xSquared / ((i + 1) * (i + 2));
        }

        return result;
    }

    public static double BuiltInSin(double x) => Math.Sin(x);
}```