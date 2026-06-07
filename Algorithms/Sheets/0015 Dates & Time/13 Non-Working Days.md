Non-Working Days 

Start = 2026, 5, 18 (monday) 

End = 2026, 5, 24 (sunday) 

Result = 2

```cs
public class NonWorkingDays
{
    // Weekends are Saturday/Sunday
    // This counts non-working days in the inclusive range [start, end]
    public static int CountNonWorkingDays(DateTime start, DateTime end)
    {
        if (start > end)
        {
            (start, end) = (end, start);
        }

        int count = 0;
        for (var d = start.Date; d <= end.Date; d = d.AddDays(1))
        {
            if (d.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                count++;
        }

        return count;
    }
}```