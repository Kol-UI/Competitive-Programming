Manage Color Inversion.
```cs
public class ColorInverter
{
    // White background -> Black text
    // Invert 255,255,255 to 0,0,0
    
    // Approach 1: Classic Bitwise/Arithmetic Inversion
    public static (int R, int G, int B) InvertRgb(int r, int g, int b)
    {
        // Subtract from max value to get the complement
        return (255 - r, 255 - g, 255 - b);
    }

    // Approach 2: Optimal Contrast Inversion
    public static (int R, int G, int B) GetBestContrast(int r, int g, int b)
    {
        // Calculate perceived brightness
        double luminance = (0.299 * r + 0.587 * g + 0.114 * b) / 255;
        
        // Return black for light backgrounds, white for dark backgrounds
        return luminance > 0.5 ? (0, 0, 0) : (255, 255, 255);
    }
}```