Returns the square root of a number. Ex : Sqrt(9) = 3 because 3x3=9
```cs
public static class Sqrt
{
    public static double GetSqrt(double x)
    {
        // Returns the square root of x. Returns NaN for negative numbers.
        // Uses the Newton-Raphson method for iterative approximation.
        if (x < 0) return double.NaN;
        if (x == 0) return 0;

        double estimate = x / 2.0;
        double lastEstimate;

        // We loop until the difference is insignificant.
        do
        {
            lastEstimate = estimate;
            estimate = (estimate + (x / estimate)) / 2.0;
        } 
        while (Math.Abs(estimate - lastEstimate) > 1e-15);

        return estimate;
    }

    public static double BuiltInSqrt(double d) => Math.Sqrt(d);
}```