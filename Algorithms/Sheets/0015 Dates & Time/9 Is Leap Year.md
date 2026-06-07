Is Leap Year
```cs
public class LeapYearChecker
{
    // Approach 1: Modulo
    public bool IsLeapYearManual(int year)
    {
        if (year < 1)
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be greater than 0.");

        // Divisible by 400 OR (Divisible by 4 AND NOT divisible by 100)
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    // Approach 2: Built-in
    public bool IsLeapYearNative(int year)
    {
        if (year < 1 || year > 9999)
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1 and 9999.");

        return DateTime.IsLeapYear(year);
    }
}```