Rounds a value to the nearest integer or to the specified number of fractional digits. Ex : 1.4 = 1
```cs
public static class Round
{
    public static double GetRound(double d)
    {
        // Classic rounding: add 0.5 and floor for positive numbers, 
        // subtract 0.5 and ceiling for negative numbers.
        if (d >= 0)
        {
            return (int)(d + 0.5);
        }
        return (int)(d - 0.5);
    }

    public static double BuiltInRound(double d)
    {
        // Rounds a value to the nearest integer. Default is 'ToEven' (banker's rounding).
        return Math.Round(d);
    }
}```