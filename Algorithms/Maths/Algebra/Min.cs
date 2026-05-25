namespace CompetitiveProgramming.Algorithms;
public static class Min
{
    public static double GetMin(double val1, double val2)
    {
        // Returns the smaller of two numbers. 
        // If they are equal, returns val1.
        return (val1 <= val2) ? val1 : val2;
    }

    public static double BuiltInMin(double val1, double val2) => Math.Min(val1, val2);
}