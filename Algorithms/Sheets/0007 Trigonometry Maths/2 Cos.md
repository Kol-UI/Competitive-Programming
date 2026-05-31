Returns the cosine of the specified angle.
```cs
public static class Cos
{
    /// <summary>
    /// cos(x) = 1 - x^2/2! + x^4/4! - x^6/6! ...
    /// </summary>
    public static double GetCos(double radians)
    {
        // We reduce the angle between -PI and PI for accuracy
        radians %= 2 * Math.PI;

        double result = 1.0;
        double term = 1.0;
        
        // We calculate the first 10 terms for good accuracy
        for (int i = 1; i <= 10; i++)
        {
            term *= -radians * radians / ((2 * i - 1) * (2 * i));
            result += term;
        }
        return result;
    }

    /// <summary>
    /// Utils conversion
    /// </summary>
    public static double ToRadians(double degrees) => degrees * (Math.PI / 180.0);
}```