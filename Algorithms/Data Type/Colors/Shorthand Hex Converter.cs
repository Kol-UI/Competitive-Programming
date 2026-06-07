using System.Text;

namespace CompetitiveProgramming.Algorithms;
public class ShorthandHexConverter
{
    // #03F" => "#0033FF"
    // "#ABC" => "#AABBCC"

    // Approach 1: String Manipulation (Expansion)
    public static string Expand(string hex)
    {
        // Remove hash if present
        string cleanHex = hex.StartsWith("#") ? hex.Substring(1) : hex;

        // Only process 3-digit shorthand
        if (cleanHex.Length != 3) return $"#{cleanHex}";

        StringBuilder sb = new StringBuilder("#");
        foreach (char c in cleanHex)
        {
            // Duplicate each component (RGB)
            sb.Append(c);
            sb.Append(c);
        }

        return sb.ToString();
    }

    // Approach 2: Normalization for CSS (Handling both cases)
    public static string Normalize(string hex)
    {
        string h = hex.TrimStart('#');
        
        if (h.Length == 3)
        {
            return $"#{h[0]}{h[0]}{h[1]}{h[1]}{h[2]}{h[2]}";
        }
        
        return $"#{h}";
    }
}