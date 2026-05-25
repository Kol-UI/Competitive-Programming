namespace CompetitiveProgramming.Algorithms;
public class Abs
{
    public static int GetAbsolute(int value)
    {
        // If value is negative, negate it to make it positive; 
        // otherwise, return it as is.
        if (value < 0)
        {
            return -value;
        }
        return value;
    }

    public static int BuiltInAbs(int value) => Math.Abs(value);
}