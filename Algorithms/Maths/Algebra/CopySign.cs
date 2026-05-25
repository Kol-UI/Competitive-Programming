namespace CompetitiveProgramming.Algorithms;
public static class CopySign
{
    public static double GetCopySign(double x, double y)
    {
        // Returns a value with the magnitude of x and the sign of y.
        // We use double.IsNegative to correctly handle -0.0.
        
        bool xIsNegative = double.IsNegative(x);
        bool yIsNegative = double.IsNegative(y);

        if (xIsNegative == yIsNegative)
        {
            return x;
        }

        return -x;
    }

    public static double BuiltInCopySign(double x, double y) => Math.CopySign(x, y);
}