Format & Parse
```cs
public class DateConverter
{
    // Approach 1: Using native TryParseExact
    // "07:05:45PM" => "19:05:45"
    public string ConvertTo24HourFormatNative(string time12Hour)
    {
        if (DateTime.TryParse(time12Hour, out DateTime parsedDate))
        {
            return parsedDate.ToString("HH:mm:ss");
        }
        return "Invalid Time";
    }

    // Approach 2: Manual Parsing using StringBuilder
    // Input format expected: "HH:MM:SSAM" or "HH:MM:SSPM" ("07:05:45PM")
    public string ConvertTo24HourFormatManual(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 10) return "Invalid Time";

        string amPm = s.Substring(8, 2);
        string hourStr = s.Substring(0, 2);
        string restOfTime = s.Substring(2, 6); // Includes ":MM:SS"

        if (!int.TryParse(hourStr, out int hours)) return "Invalid Time";
        if (hours < 1 || hours > 12) return "Invalid Time";

        if (amPm == "PM" && hours != 12)
        {
            hours += 12;
        }
        else if (amPm == "AM" && hours == 12)
        {
            hours = 0;
        }

        StringBuilder sb = new();
        sb.Append(hours.ToString("D2"));
        sb.Append(restOfTime);

        return sb.ToString();
    }
}```