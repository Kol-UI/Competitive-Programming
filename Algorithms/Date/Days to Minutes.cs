namespace CompetitiveProgramming.Algorithms;

public class DaysConverter
{
    // Approach 1: Checked multiplication with Overflow detection
    public int ConvertDaysToMinutesChecked(int days)
    {
        if (days < 0) return -1; 

        // 1 day = 24 hours * 60 minutes = 1440 minutes
        const int minutesInDay = 1440;

        try
        {
            // Checked blocks throw OverflowException if value exceeds int.MaxValue
            return checked(days * minutesInDay);
        }
        catch (OverflowException)
        {
            return -2; // Code for overflow error
        }
    }

    // Approach 2: Using long and TimeSpan
    public long ConvertDaysToMinutesLong(int days)
    {
        if (days < 0) return -1;

        // Use long to prevent any overflow during math
        long totalMinutes = (long)days * (long)TimeSpan.MinutesPerDay;
        return totalMinutes;
    }
}