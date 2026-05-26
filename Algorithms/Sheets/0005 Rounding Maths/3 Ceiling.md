Returns the smallest integral value greater than or equal to the specified number.
```cs
public static class Ceiling
{
    public static double GetCeiling(double d)
    {
        // Returns the smallest integer greater than or equal to d.
        // For positive numbers with decimals, increment the truncated value.
        
        long i = (long)d; // truncate
        
        // If the number has a decimal part and is positive, we move up to the next integer.
        if (d > 0 && d != i)
        {
            return i + 1;
        }
        
        // For negative values, the truncation (e.g., -1.9 -> -1) is already the ceiling.
        return i;
    }

    public static double BuiltInCeiling(double d) => Math.Ceiling(d);
}```