namespace CompetitiveProgramming.Algorithms;

public static class Log
{
    /// <summary>
    ///  2 * [(z-1)/(z+1) + 1/3*((z-1)/(z+1))^3 + ...]
    /// </summary>
    public static double GetLog(double x)
    {
        if (x <= 0) return double.NaN;

        // We use a transformation to ensure rapid convergence
        double z = (x - 1) / (x + 1);
        double z2 = z * z;
        double result = 0;
        double term = z;

        // 50 iterations for very good accuracy
        for (int i = 1; i < 100; i += 2)
        {
            result += term / i;
            term *= z2;
        }

        return 2 * result;
    }

    /// <summary>
    /// Built-In
    /// </summary>
    public static double BuiltInLog(double d) => Math.Log(d);
}