namespace CompetitiveProgramming.Algorithms;

public class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        return (year <= 1917 && year % 4 == 0)
            || (year >= 1919 && (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)));
    }
}