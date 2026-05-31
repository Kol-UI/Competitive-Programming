namespace CompetitiveProgramming.Algorithms;
public static class BitIncrement
{
    public static double GetBitIncrement(double d)
    {
        // Finds the next largest representable floating-point number 
        // by incrementing the underlying 64-bit integer representation.

        if (double.IsNaN(d)) return double.NaN;
        if (double.IsPositiveInfinity(d)) return double.PositiveInfinity;
        if (d == -0.0) return 0.0;

        long bits = BitConverter.DoubleToInt64Bits(d);


        if (d >= 0) bits++;
        else bits--;

        return BitConverter.Int64BitsToDouble(bits);
    }

    public static double BuiltInBitIncrement(double d) => Math.BitIncrement(d);
}