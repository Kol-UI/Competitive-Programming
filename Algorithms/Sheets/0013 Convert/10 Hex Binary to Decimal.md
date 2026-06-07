Convert Hex/Binary to Decimal.
```cs
public class BaseToDecimalConverter
{
    // 1010 => 10
    public static int BinaryToDecimal(string binary)
    {
        if (string.IsNullOrWhiteSpace(binary)) return 0;

        try
        {
            // 2 for base 2
            return Convert.ToInt32(binary, 2);
        }
        catch
        {
            return 0;
        }
    }

    // FF => 255
    public static int HexToDecimal(string hex)
    {
        if (string.IsNullOrWhiteSpace(hex)) return 0;

        try
        {
            // 16 for base 16
            return Convert.ToInt32(hex, 16);
        }
        catch
        {
            return 0;
        }
    }

    // More Modern Approach Hex using NumberStyles
    public static int HexToDecimalModern(string hex)
    {
        if (string.IsNullOrWhiteSpace(hex)) return 0;

        // Clean 0x prefix
        string cleanHex = hex.StartsWith("0x", StringComparison.OrdinalIgnoreCase) 
            ? hex.Substring(2) 
            : hex;

        if (int.TryParse(cleanHex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int result))
        {
            return result;
        }

        return 0;
    }
}```