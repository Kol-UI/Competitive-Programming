using System.Text;

namespace CompetitiveProgramming.Algorithms;
public class MinutesConverter
{
    // Approach 1: Manual Calculation
    public string FormatMinutesManual(int minutes)
    {
        if (minutes == 0) return "now";

        // Time units in minutes
        int hour = 60;
        int day = hour * 24;
        int year = day * 365;

        int[] unitValues = { year, day, hour, 1 };
        string[] unitNames = { "year", "day", "hour", "minute" };
        List<string> parts = [];

        // Calculate each time unit
        for (int i = 0; i < unitValues.Length; i++)
        {
            int value = minutes / unitValues[i];
            if (value > 0)
            {
                string suffix = value > 1 ? "s" : "";
                parts.Add($"{value} {unitNames[i]}{suffix}");
                minutes %= unitValues[i];
            }
        }

        return FormatParts(parts);
    }

    // Approach 2: Using TimeSpan
    public string FormatMinutesTimeSpan(int minutes)
    {
        if (minutes == 0) return "now";

        TimeSpan t = TimeSpan.FromMinutes(minutes);
        List<string> parts = [];

        // TimeSpan.Days includes all days, we separate them into years and days
        int years = t.Days / 365;
        int days = t.Days % 365;

        if (years > 0) parts.Add($"{years} year{(years > 1 ? "s" : "")}");
        if (days > 0) parts.Add($"{days} day{(days > 1 ? "s" : "")}");
        if (t.Hours > 0) parts.Add($"{t.Hours} hour{(t.Hours > 1 ? "s" : "")}");
        if (t.Minutes > 0) parts.Add($"{t.Minutes} minute{(t.Minutes > 1 ? "s" : "")}");

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
}