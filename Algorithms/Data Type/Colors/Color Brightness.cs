namespace CompetitiveProgramming.Algorithms;
public class ColorBrightnessManager
{
    // Approach 1: Linear RGB scaling
    public static (int R, int G, int B) AdjustBrightnessLinear(int r, int g, int b, double factor)
    {
        // factor > 0 to brighten, < 0 to darken
        if (factor > 0)
        {
            r = (int)(r + (255 - r) * factor);
            g = (int)(g + (255 - g) * factor);
            b = (int)(b + (255 - b) * factor);
        }
        else
        {
            r = (int)(r * (1 + factor));
            g = (int)(g * (1 + factor));
            b = (int)(b * (1 + factor));
        }

        return (Math.Clamp(r, 0, 255), Math.Clamp(g, 0, 255), Math.Clamp(b, 0, 255));
    }

    // Approach 2: Relative Luminance (simplified formula)
    public static double GetLuminance(int r, int g, int b)
    {
        // Standard formula for perceived brightness
        return (0.2126 * r + 0.7152 * g + 0.0722 * b) / 255.0;
    }
}