Day of the Week
```cs
public class DayOfTheWeekFinder
{
    // Approach 1: Native
    public DayOfWeek GetDayNative(int year, int month, int day)
    {
        var date = new DateTime(year, month, day);
        return date.DayOfWeek;
    }

    // Approach 2: Zeller's Congruence Algorithm
    public DayOfWeek GetDayZeller(int year, int month, int day)
    {
        if (year < 1 || month < 1 || month > 12 || day < 1 || day > 31)
            throw new ArgumentOutOfRangeException("Invalid date components.");

        // Zeller's adjustment: January and February are counted as months 13 and 14 of the previous year
        if (month == 1 || month == 2)
        {
            month += 12;
            year--;
        }

        int q = day;
        int m = month;
        int K = year % 100;
        int J = year / 100;

        // Zeller's formula for Gregorian calendar
        int h = (q + (13 * (m + 1)) / 5 + K + K / 4 + J / 4 + 5 * J) % 7;

        // Map Zeller's output (0 = Saturday, 1 = Sunday, ...) to .NET DayOfWeek (0 = Sunday, 1 = Monday, ...)
        return h switch
        {
            0 => DayOfWeek.Saturday,
            1 => DayOfWeek.Sunday,
            2 => DayOfWeek.Monday,
            3 => DayOfWeek.Tuesday,
            4 => DayOfWeek.Wednesday,
            5 => DayOfWeek.Thursday,
            6 => DayOfWeek.Friday,
            _ => throw new InvalidOperationException()
        };
    }
}```