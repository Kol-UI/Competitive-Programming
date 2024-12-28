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

    private static string DayOfWeek(int day, int month, int year)
    {
        if (month < 3)
        {
            month += 12;
            year -= 1;
        }
        int k = year % 100;
        int j = year / 100;
        int h = (day + (13 * (month + 1)) / 5 + k + k / 4 + j / 4 - 2 * j) % 7;
        string[] daysOfWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        return daysOfWeek[(h + 7) % 7];
    }

    private static int ToJulianDay(int day, int month, int year)
    {
        if (month <= 2)
        {
            year--;
            month += 12;
        }
        int a = year / 100;
        int b = 2 - a + a / 4;
        return (int)(365.25 * (year + 4716)) + (int)(30.6001 * (month + 1)) + day + b - 1524;
    }
}