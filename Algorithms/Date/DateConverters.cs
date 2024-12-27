namespace CompetitiveProgramming.Algorithms;

public class DateConverters
{
    private static int GetNumberOfDaysInMonth(int year, int month)
    {
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            return 31;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            return 30;
        }
        else if (year == 1918)
        {
            return 15;
        }
        else if (IsLeapYear(year))
        {
            return 29;
        }
        else
        {
            return 28;
        }
    }

    private static bool IsLeapYear(int year)
    {
        return (year <= 1917 && year % 4 == 0)
            || (year >= 1919 && (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)));
    }
}