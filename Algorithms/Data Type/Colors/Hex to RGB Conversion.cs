using System.Globalization;

namespace CompetitiveProgramming.Algorithms;
public class HexConverter
{
    // System.Globalization Approach
    // #FFFFFF => 255,255,255
    public static (int R, int G, int B) HexToRgb(string hex)
    {
        // clean # prefix
        hex = hex.StartsWith("#") ? hex.Substring(1) : hex;

        if (hex.Length != 6)
            throw new ArgumentException("hex format has 6 char min.");

        int r = int.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
        int g = int.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
        int b = int.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);

        return (r, g, b);
    }

    // Span & Bit shift Approach
    // #FFFFFF => 255,255,255
    public static (int R, int G, int B) HexToRgbSpanBitShift(string hex)
    {
        ReadOnlySpan<char> span = hex.AsSpan();
        if (span.StartsWith("#")) span = span.Slice(1);

        if (span.Length != 6)
            throw new ArgumentException("Format invalide.");

        int rgb = Convert.ToInt32(span.ToString(), 16);

        return (
            (rgb >> 16) & 0xFF, // shift 16 bits for red
            (rgb >> 8) & 0xFF,  // shift  8 bits for green
            rgb & 0xFF          // isolate blue
        );
    }
}