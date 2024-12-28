namespace CompetitiveProgramming.Algorithms;

public class CountDate
{
    private static int DaysInMonth(int month, int year)
    {
        if (month < 1 || month > 12) throw new ArgumentException("Invalid month");
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year)) return 29;
        return days[month - 1];
    }

    private static bool IsLeapYear(int year)
    {
        return (year <= 1917 && year % 4 == 0) || (year >= 1919 && (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)));
    }

    private static int DaysBetweenDates((int day, int month, int year) date1, (int day, int month, int year) date2)
    {
        int days = 0;
        if (date1.year > date2.year || (date1.year == date2.year && date1.month > date2.month) || (date1.year == date2.year && date1.month == date2.month && date1.day > date2.day))
        {
            var temp = date1;
            date1 = date2;
            date2 = temp;
        }

        while (date1 != date2)
        {
            days++;
            date1 = AddDays(date1.day, date1.month, date1.year, 1);
        }

        return days;
    }

    private static (int day, int month, int year) AddDays(int day, int month, int year, int daysToAdd)
    {
        while (daysToAdd > 0)
        {
            int daysInCurrentMonth = DaysInMonth(month, year);
            if (day + daysToAdd <= daysInCurrentMonth)
            {
                day += daysToAdd;
                daysToAdd = 0;
            }
            else
            {
                daysToAdd -= (daysInCurrentMonth - day + 1);
                day = 1;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }
        return (day, month, year);
    }

    private static (int day, int month, int year) AddMonths(int day, int month, int year, int monthsToAdd)
    {
        month += monthsToAdd;
        year += (month - 1) / 12;
        month = (month - 1) % 12 + 1;

        int daysInMonth = DaysInMonth(month, year);
        if (day > daysInMonth) day = daysInMonth;

        return (day, month, year);
    }
}