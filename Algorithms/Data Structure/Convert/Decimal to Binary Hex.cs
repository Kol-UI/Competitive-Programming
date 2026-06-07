namespace CompetitiveProgramming.Algorithms;
public class NumberBaseConverter
{
    // Convert int to binary (base 2)
    // 10 => 1010
    // 25 => 11111111
    public static string ToBinary(int number)
    {
        // Convert.ToString(number, base)
        return Convert.ToString(number, 2);
    }

    // Convert int to hex (base 16)
    // 255 => FF
    // 16 => 10
    public static string ToHex(int number, bool upperCase = true)
    {
        string hex = Convert.ToString(number, 16);
        return upperCase ? hex.ToUpper() : hex.ToLower();
    }

    public static string ToBinaryManual(int number)
    {
        if (number == 0) return "0";
        string binary = "";
        while (number > 0)
        {
            binary = (number % 2) + binary;
            number /= 2;
        }
        return binary;
    }

    public static string ToHexInterpolated(int number, bool upperCase = true)
    {
        // X for uppercase, x for lowercase
        return upperCase ? $"{number:X}" : $"{number:x}";
    }
}