namespace CompetitiveProgramming.Algorithms;
public class DigitalClockConverter
{
    // Approach 1: Math calculation using raw integers.
    // Returns the smallest angle (between 0 and 180 degrees)
    public double CalculateAngle(int Hours, int Minutes)
    {
        // Handle 12-hour format wrap
        int H = Hours % 12;

        // Calculate positions in degrees from 12 o'clock position
        double MinuteAngle = Minutes * 6; // 360 / 60 = 6 degrees per minute
        double HourAngle = (H * 30) + (Minutes * 0.5); // 30 deg per hour + 0.5 deg per minute

        // Find the absolute difference
        double Angle = Math.Abs(HourAngle - MinuteAngle);

        // Return the minimal/acute angle
        return Angle > 180 ? 360 - Angle : Angle;
    }

    // Approach 2: String parsing format ("HH:MM")
    public double CalculateAngleFromString(string Time)
    {
        if (string.IsNullOrWhiteSpace(Time) || !Time.Contains(':'))
        {
            throw new ArgumentException("Invalid time format");
        }

        string[] Parts = Time.Split(':');
        int Hours = int.Parse(Parts[0]);
        int Minutes = int.Parse(Parts[1]);

        return CalculateAngle(Hours, Minutes);
    }
}