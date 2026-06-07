namespace CompetitiveProgramming.Algorithms;
public class WeeksToHoursConverter
{
    // Approach 1
    public int ConvertToHoursStandard(int weeks)
    {
        if (weeks < 0) 
            throw new ArgumentException("Weeks cannot be negative.");
            
        // 7 days * 24 hours = 168 hours per week
        return weeks * 168;
    }

    // Approach 2: Defensive overflow handling for large inputs
    public long ConvertToHoursSafe(int weeks)
    {
        if (weeks < 0) 
            throw new ArgumentException("Weeks cannot be negative.");

        // Cast to long to prevent integer overflow
        return (long)weeks * 168;
    }
}