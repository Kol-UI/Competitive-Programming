Log Formatter

```cs
// Problem: normalize raw log lines into "yyyy-MM-dd HH:mm:ss | LEVEL | message".
// Input example: "  [2024-01-05 10:23:11] error :   disk full   "
// Output example: "2024-01-05 10:23:11 | ERROR | disk full"
// Unknown/missing parts should become "UNKNOWN" (level) or "" (message), never throw.

public class LogFormatterManual
{
    public string Format(string rawLog)
    {
        if (string.IsNullOrWhiteSpace(rawLog))
            return "UNKNOWN | UNKNOWN | ";

        var line = rawLog.Trim();

        // extract timestamp inside brackets
        int openBracket = line.IndexOf('[');
        int closeBracket = line.IndexOf(']');
        string timestamp = "UNKNOWN";
        string rest = line;

        if (openBracket >= 0 && closeBracket > openBracket)
        {
            timestamp = line.Substring(openBracket + 1, closeBracket - openBracket - 1).Trim();
            rest = line.Substring(closeBracket + 1).Trim();
        }

        // split level and message on first ':'
        int colonIndex = rest.IndexOf(':');
        string level;
        string message;

        if (colonIndex >= 0)
        {
            level = rest.Substring(0, colonIndex).Trim();
            message = rest.Substring(colonIndex + 1).Trim();
        }
        else
        {
            level = "UNKNOWN";
            message = rest.Trim();
        }

        if (string.IsNullOrWhiteSpace(level))
            level = "UNKNOWN";

        var sb = new StringBuilder();
        sb.Append(timestamp);
        sb.Append(" | ");
        sb.Append(level.ToUpperInvariant());
        sb.Append(" | ");
        sb.Append(message);

        return sb.ToString();
    }
}

public class LogFormatterRegex
{
    // group 1: timestamp, group 2: level, group 3: message
    private static readonly Regex Pattern = new Regex(@"^\s*(?:\[(?<ts>[^\]]+)\])?\s*(?:(?<level>\w+)\s*:)?\s*(?<msg>.*)$", RegexOptions.Compiled);

    public string Format(string rawLog)
    {
        if (string.IsNullOrWhiteSpace(rawLog))
            return "UNKNOWN | UNKNOWN | ";

        var match = Pattern.Match(rawLog);

        string timestamp = match.Groups["ts"].Success ? match.Groups["ts"].Value.Trim() : "UNKNOWN";

        string level = match.Groups["level"].Success ? match.Groups["level"].Value.Trim().ToUpperInvariant() : "UNKNOWN";

        string message = match.Groups["msg"].Value.Trim();

        return $"{timestamp} | {level} | {message}";
    }
}```