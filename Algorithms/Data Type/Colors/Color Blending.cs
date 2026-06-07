namespace CompetitiveProgramming.Algorithms;
public class ColorBlender
{
    // Approach 1: Simple Linear Interpolation (Lerp)
    public static (int R, int G, int B) Lerp(
        (int R, int G, int B) colorA, 
        (int R, int G, int B) colorB, 
        double amount)
    {
        // amount 0.0 is colorA, 1.0 is colorB
        amount = Math.Clamp(amount, 0.0, 1.0);

        int r = (int)(colorA.R + (colorB.R - colorA.R) * amount);
        int g = (int)(colorA.G + (colorB.G - colorA.G) * amount);
        int b = (int)(colorA.B + (colorB.B - colorA.B) * amount);

        return (r, g, b);
    }

    // Approach 2: Alpha Blending (Source over Destination)
    public static (int R, int G, int B) AlphaBlend(
        (int R, int G, int B) background, 
        (int R, int G, int B) foreground, 
        double alpha)
    {
        // alpha: 0.0 (transparent) to 1.0 (opaque)
        alpha = Math.Clamp(alpha, 0.0, 1.0);

        int r = (int)((foreground.R * alpha) + (background.R * (1.0 - alpha)));
        int g = (int)((foreground.G * alpha) + (background.G * (1.0 - alpha)));
        int b = (int)((foreground.B * alpha) + (background.B * (1.0 - alpha)));

        return (r, g, b);
    }
}