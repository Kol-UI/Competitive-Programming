Returns value clamped to the inclusive range of min and max. Math.Clamp(value, min, max) forces a value to remain within a given range. The concept: It's a safety mechanism. If your value is too small, it moves up to the minimum. If it's too large, it moves down to the maximum. If it's already between the two, it stays put.
```cs
public static class Clamp
{
    public static double GetClamp(double value, double min, double max)
    {
        // If value < min, return min. If value > max, return max. 
        // Otherwise, return value.
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

    public static double BuiltInClamp(double value, double min, double max)
    {
        return Math.Clamp(value, min, max);
    }
}```