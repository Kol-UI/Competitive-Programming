namespace CompetitiveProgramming.Algorithms;
public static class Floor
{
    public static double GetFloor(double d)
    {
        // Returns the largest integer less than or equal to d.
        // For negative numbers, if there's a decimal, we must subtract 1.
        
        long i = (long)d; // We truncate the decimal part
        
        if (d < 0 && d != i)
        {
            return i - 1;
        }
        
        return i;
    }

    public static double BuiltInFloor(double d) => Math.Floor(d);
}