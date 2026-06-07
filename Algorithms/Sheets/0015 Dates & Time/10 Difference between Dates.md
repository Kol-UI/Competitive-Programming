Difference between Dates
```cs
public class DifferenceBetweenDates
{
    // Returns the absolute difference between two dates as:
    // - total days if time components are ignored
    // - or exact TimeSpan if time components are kept.
    public static long GetDifferenceInDays(DateTime a, DateTime b, bool ignoreTime)
    {
        if (ignoreTime)
        {
            a = a.Date;
            b = b.Date;
        }

        var diff = a > b ? a - b : b - a;
        return (long)diff.TotalDays;
    }

    // Returns difference in days as an exact TimeSpan, converted to whole days
    public static long GetDifferenceInWholeDays(DateTime a, DateTime b)
    {
        var diff = a > b ? a - b : b - a;
        return (long)diff.TotalDays; // truncates toward zero for positive values
    }
}```