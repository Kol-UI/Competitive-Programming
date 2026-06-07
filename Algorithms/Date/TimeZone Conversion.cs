namespace CompetitiveProgramming.Algorithms;
public class TimeZoneConverter
{
    // Approach 1: Convert directly between two specific time zones.
    public DateTimeOffset ConvertDirect(DateTimeOffset SourceTime, string TargetZoneId)
    {
        TimeZoneInfo TargetZone = TimeZoneInfo.FindSystemTimeZoneById(TargetZoneId);
        return TimeZoneInfo.ConvertTime(SourceTime, TargetZone);
    }
    
    // Approach 2: Anchor to UTC first, then convert to target
    public DateTimeOffset ConvertViaUtc(DateTimeOffset SourceTime, string TargetZoneId)
    {
        // Force conversion to UTC first (safe anchor)
        DateTimeOffset UtcTime = SourceTime.ToUniversalTime();

        // Convert UTC to target time zone
        TimeZoneInfo TargetZone = TimeZoneInfo.FindSystemTimeZoneById(TargetZoneId);
        return TimeZoneInfo.ConvertTime(UtcTime, TargetZone);
    }
}