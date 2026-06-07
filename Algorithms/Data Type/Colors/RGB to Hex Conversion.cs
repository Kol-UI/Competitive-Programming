namespace CompetitiveProgramming.Algorithms;
public class RgbConverter
{
    // X2 Approach
    // 255,255,255 => #FFFFFF
    public static string RgbToHex(int r, int g, int b)
    {
        // validate entries (0-255)
        r = Math.Clamp(r, 0, 255);
        g = Math.Clamp(g, 0, 255);
        b = Math.Clamp(b, 0, 255);
        // X2 forces the hexadecimal to uppercase for 2 characters
        return $"#{r:X2}{g:X2}{b:X2}";
    }

    // Bit Shifting Approach
    // 255,255,255 => #FFFFFF
    public static string RgbToHexBitShift(int r, int g, int b)
    {
        r = Math.Max(0, Math.Min(255, r));
        g = Math.Max(0, Math.Min(255, g));
        b = Math.Max(0, Math.Min(255, b));

        int rgb = (r << 16) | (g << 8) | b;

        // X6 for 6 characters
        return "#" + rgb.ToString("X6");
    }
}