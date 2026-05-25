Returns x * 2^n computed efficiently.
```cs
public static class ScaleB
{
    /// <summary>
    /// Calculate x * 2^n
    /// </summary>
    public static double GetScaleB(double x, int n)
    {
        // Returns x * 2^n. It scales the floating-point number by an integer 
        // power of 2 by adjusting the exponent of the binary representation 
        // instead of performing a standard multiplication.
        if (double.IsNaN(x) || double.IsInfinity(x) || x == 0)
        {
            return x;
        }
        return x * Math.Pow(2, n);
    }

    public static double BuiltInScaleB(double x, int n) => Math.ScaleB(x, n);
}```