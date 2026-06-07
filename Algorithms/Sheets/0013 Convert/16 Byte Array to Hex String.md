Convert Byte Array to Hex as String.
```cs
public class ByteArraytoHexString
{
    public static string ConvertToHexString(byte[] data) => Convert.ToHexString(data);

    public static string ConvertToStringReplace(byte[] data) => BitConverter.ToString(data).Replace("-", "");
    public static string ConvertStringBuilder(byte[] data)
    {
        StringBuilder sb = new(data.Length * 2);
        foreach (byte b in data)
        {
            sb.Append(b.ToString("X2")); // "X2" for hex in uppercase
        }
        return sb.ToString();
    }
}```