Returns the cube root of a number. Ex : Cbrt(27) = 3 because 3x3x3=27
```cs
public static class Cbrt
{
    public static double GetCbrt(double d)
    {
        // Returns the cube root of a number
        // Handles negative values by using the property: cbrt(-x) = -cbrt(x)
        if (d == 0) return 0;

        if (d < 0)
        {
            // For negative numbers, we calculate the square root of the positive number and invert it
            return -Math.Pow(-d, 1.0 / 3.0);
        }

        return Math.Pow(d, 1.0 / 3.0);
    }

    public static double BuiltInCbrt(double d) => Math.Cbrt(d);
}```