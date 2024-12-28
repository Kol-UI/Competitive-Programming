namespace CompetitiveProgramming.Algorithms;

public class TimeConverters
{
    private static int HoursToMinutes(int hours)
    {
        return hours * 60;
    }

    private static int MinutesToHours(int minutes)
    {
        return minutes / 60;
    }

    private static int HoursToDays(int hours)
    {
        return hours / 24;
    }

    private static double HoursToDaysPrecise(double hours)
    {
        return hours / 24.0;
    }


    private static int DaysToHours(int days)
    {
        return days * 24;
    }

    private static int DaysToMinutes(int days)
    {
        return days * 24 * 60;
    }

    private static int MinutesToDays(int minutes)
    {
        return minutes / (24 * 60);
    }

    private static double MinutesToDaysPrecise(double minutes)
    {
        return minutes / (24.0 * 60.0);
    }

    private static int SecondsToMinutes(int seconds)
    {
        return seconds / 60;
    }

    private static double SecondsToMinutesPrecise(double seconds)
    {
        return seconds / 60.0;
    }

    private static int SecondsToHours(int seconds)
    {
        return seconds / 3600;
    }

    private static double SecondsToHoursPrecise(double seconds)
    {
        return seconds / 3600.0;
    }


    private static int SecondsToDays(int seconds)
    {
        return seconds / (24 * 3600);
    }

    private static double SecondsToDaysPrecise(double seconds)
    {
        return seconds / (24.0 * 3600.0);
    }


    private static int MinutesToSeconds(int minutes)
    {
        return minutes * 60;
    }

    private static int HoursToSeconds(int hours)
    {
        return hours * 3600;
    }

    private static int DaysToSeconds(int days)
    {
        return days * 24 * 3600;
    }
}