namespace CompetitiveProgramming.Algorithms;
public static class FusedMultiplyAdd
{
    public static double GetFusedMultiplyAdd(double x, double y, double z)
    {
        /*
         * Computes (x * y) + z as a single operation. 
         * In hardware, this prevents intermediate rounding errors by performing 
         * the multiplication and addition with infinite precision before a single final rounding.
         * Logic: result = (x * y) + z.
         */

        if (double.IsNaN(x) || double.IsNaN(y) || double.IsNaN(z))
            return double.NaN;

        return (x * y) + z;
    }

    public static double BuiltInFMA(double x, double y, double z) => Math.FusedMultiplyAdd(x, y, z);
}