File Size Humanizer

```cs
// Problem: convert a byte count into a human readable string.
// Example: 0 -> "0 B", 1536 -> "1.5 KB", 1073741824 -> "1.0 GB"
// Units: B, KB, MB, GB, TB (base 1024), one decimal place.

// Approach 1 : Loop
public class FileSizeHumanizerLoop
{
    private static readonly string[] Units = { "B", "KB", "MB", "GB", "TB", "PB" };

    public string Humanize(long bytes)
    {
        if (bytes < 0)
            throw new ArgumentOutOfRangeException(nameof(bytes), "Size cannot be negative.");

        if (bytes == 0)
            return "0 B";

        double size = bytes;
        int unitIndex = 0;

        while (size >= 1024 && unitIndex < Units.Length - 1)
        {
            size /= 1024;
            unitIndex++;
        }

        // bytes stay as a whole number, other units get one decimal
        string formatted = unitIndex == 0 ? size.ToString("0") : size.ToString("0.0");

        return $"{formatted} {Units[unitIndex]}";
    }
}

// Approach 2 : Math
public class FileSizeHumanizerMath
{
    private static readonly string[] Units = { "B", "KB", "MB", "GB", "TB", "PB" };

    public string Humanize(long bytes)
    {
        if (bytes < 0)
            throw new ArgumentOutOfRangeException(nameof(bytes), "Size cannot be negative.");

        if (bytes == 0)
            return "0 B";

        // compute power of 1024 directly via log, clamped to available units
        int unitIndex = (int)Math.Log(bytes, 1024);
        unitIndex = Math.Min(unitIndex, Units.Length - 1);

        double size = bytes / Math.Pow(1024, unitIndex);

        string formatted = unitIndex == 0 ? size.ToString("0") : size.ToString("0.0");

        return $"{formatted} {Units[unitIndex]}";
    }
}```