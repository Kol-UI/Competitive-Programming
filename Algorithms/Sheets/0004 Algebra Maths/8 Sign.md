Returns an integer that indicates the sign of a number. Returns -1 if less than zero Returns 0 is egal to zero Returns 1 if greater than zero
```cs
public static class Sign
{
    public static int GetSign(double d)
    {
        // Returns 1, 0, or -1 based on the polarity of the input.
        if (d > 0) return 1;
        if (d < 0) return -1;
        return 0;
    }

    public static int BuiltInSign(double d) => Math.Sign(d);
}```