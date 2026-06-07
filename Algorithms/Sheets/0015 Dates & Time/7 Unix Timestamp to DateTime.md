1716200000 = May 20, 2024

```cs
public class UnixTimestampConverter
{
    private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    // Approach 1: Native
    public DateTime ConvertWithNativeApi(long timestamp)
    {
        if (timestamp < -62135596800 || timestamp > 253402300799)
            throw new ArgumentOutOfRangeException(nameof(timestamp), "Timestamp falls outside of valid DateTime range.");

        return DateTimeOffset.FromUnixTimeSeconds(timestamp).UtcDateTime;
    }

    // Approach 2: Manual Math - Adds seconds directly to the Epoch
    public DateTime ConvertFromScratch(long timestamp)
    {
        // DateTime.Max/Min limits validation
        if (timestamp < -62135596800 || timestamp > 253402300799)
            throw new ArgumentOutOfRangeException(nameof(timestamp), "Timestamp falls outside of valid DateTime range.");

        return UnixEpoch.AddSeconds(timestamp);
    }
}```