Working Days 

Start = 2026, 5, 18 (monday) 

End = 2026, 5, 24 (sunday) 

Result = 5

```cs
public class WorkingDays
{
    // Weekends are Saturday/Sunday
    // This counts workdays in the inclusive range [start, end]
    public static int CountWorkingDays(DateTime start, DateTime end)
    {
        if (start > end)
        {
            (start, end) = (end, start);
        }

        int count = 0;
        for (var d = start.Date; d <= end.Date; d = d.AddDays(1))
        {
            if (d.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                continue;

            count++;
        }

        return count;
    }
}```