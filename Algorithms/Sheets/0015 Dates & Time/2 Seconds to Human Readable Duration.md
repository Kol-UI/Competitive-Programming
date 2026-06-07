Seconds to Human Readable Duration

0 => "now" 

1 => "1 second" 

62 => "1 minute and 2 seconds" 

120 => "2 minutes" 

3662 => "1 hour, 1 minute and 2 seconds" 

157310085 => "4 years, 360 days, 17 hours, 14 minutes and 45 seconds"

```cs
public class DurationConverter
{
    // Approach 1: Manual Calculation (LeetCode style)
    public string FormatDurationManual(int seconds)
    {
        if (seconds == 0) return "now";

        // Time units in seconds
        int minute = 60;
        int hour = minute * 60;
        int day = hour * 24;
        int year = day * 365;

        int[] unitValues = { year, day, hour, minute, 1 };
        string[] unitNames = { "year", "day", "hour", "minute", "second" };
        List<string> parts = [];

        // Calculate each time unit
        for (int i = 0; i < unitValues.Length; i++)
        {
            int value = seconds / unitValues[i];
            if (value > 0)
            {
                string suffix = value > 1 ? "s" : "";
                parts.Add($"{value} {unitNames[i]}{suffix}");
                seconds %= unitValues[i];
            }
        }

        return FormatParts(parts);
    }

    // Approach 2: Using TimeSpan
    public string FormatDurationTimeSpan(int seconds)
    {
        if (seconds == 0) return "now";

        TimeSpan t = TimeSpan.FromSeconds(seconds);
        List<string> parts = [];

        // TimeSpan doesn't support years directly (approximated here as 365 days)
        int years = t.Days / 365;
        int days = t.Days % 365;

        if (years > 0) parts.Add($"{years} year{(years > 1 ? "s" : "")}");
        if (days > 0) parts.Add($"{days} day{(days > 1 ? "s" : "")}");
        if (t.Hours > 0) parts.Add($"{t.Hours} hour{(t.Hours > 1 ? "s" : "")}");
        if (t.Minutes > 0) parts.Add($"{t.Minutes} minute{(t.Minutes > 1 ? "s" : "")}");
        if (t.Seconds > 0) parts.Add($"{t.Seconds} second{(t.Seconds > 1 ? "s" : "")}");

        return FormatParts(parts);
    }

    // Helper method to join parts with commas and "and"
    private string FormatParts(List<string> parts)
    {
        if (parts.Count == 1) return parts[0];

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < parts.Count; i++)
        {
            sb.Append(parts[i]);
            if (i == parts.Count - 2)
            {
                sb.Append(" and ");
            }
            else if (i < parts.Count - 2)
            {
                sb.Append(", ");
            }
        }
        return sb.ToString();
    }
}```