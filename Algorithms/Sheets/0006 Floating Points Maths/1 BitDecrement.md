Finds the next smallest representable floating-point number.
```cs
public static class BitDecrement
{
    public static double GetBitDecrement(double d)
    {
        // Finds the next smallest representable floating-point number.
        // It converts the double to its 64-bit integer representation to decrement it.
        
        if (double.IsNaN(d)) return double.NaN;
        if (double.IsNegativeInfinity(d)) return double.NegativeInfinity;
        if (d == 0.0) return -double.Epsilon;

        long bits = BitConverter.DoubleToInt64Bits(d);

        if (d > 0) bits--;
        else bits++;

        return BitConverter.Int64BitsToDouble(bits);
    }

    public static double BuiltInBitDecrement(double d) => Math.BitDecrement(d);
}```