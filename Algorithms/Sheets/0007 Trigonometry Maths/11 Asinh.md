Returns the angle whose hyperbolic sine is the specified number.
```cs
public class Asinh
{
    public static double GetAsinh(double x)
    {
        // asinh(x) = ln(x + sqrt(x^2 + 1)). Defined for all real numbers.
        return Math.Log(x + Math.Sqrt(x * x + 1.0));
    }

    public static double BuiltInAsinh(double d)
    {
        // Returns the inverse hyperbolic sine of the specified number.
        return Math.Asinh(d);
    }
}```