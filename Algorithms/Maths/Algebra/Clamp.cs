namespace CompetitiveProgramming.Algorithms;
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
}