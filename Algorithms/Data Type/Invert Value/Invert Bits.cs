namespace CompetitiveProgramming.Algorithms;
public class InvertBits
{
    // Inverts all bits of a 32-bit integer.
    // Example: 0000...0001 (1) becomes 1111...1110 (-2)
    public static int InvertAll(int number)
    {
        return ~number;
    }

    // Inverts all bits of a 32-bit integer whitout ~
    public static int InvertManually(int number)
    {
        int result = 0;
        for (int i = 0; i < 32; i++)
        {
            // Isolate the i-th bit
            int bit = (number >> i) & 1;
            
            // Invert the bit (1 becomes 0, 0 becomes 1)
            int invertedBit = (bit == 0) ? 1 : 0;
            
            // Place the inverted bit back at the same position
            result |= invertedBit << i;
        }
        return result;
    }

    // Inverts only the first 'n' bits of a number using a bitmask
    public static int InvertFirstNBits(int number, int n)
    {
        // Create a mask with 'n' ones at the end (e.g., n=3 -> 00...0111)
        int mask = (1 << n) - 1;
        // XOR the number with the mask to flip only those bits
        return number ^ mask;
    }

    // Converts a number to a binary string representation for debugging/visualization
    // 1 => "00000000000000000000000000000001"
    public static string ToBinaryString(int number)
    {
        return Convert.ToString(number, 2).PadLeft(32, '0');
    }
}