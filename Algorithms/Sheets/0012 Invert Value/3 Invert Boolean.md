Invert a given boolean by using multiple approaches
```cs
public class InvertBoolean
{
    // Basic Approach
    public static bool InvertBooleanBasic(bool value)
    {
        return !value;
    }

    // XOR Approach : true XOR true = false, false XOR true = true
    public static bool InvertWithXor(bool value)
    {
        return value ^ true;
    }

    // Math Approach
    // Inverts a boolean by treating it as an integer (0 or 1)
    public static bool InvertWithMath(bool value)
    {
        int bit = value ? 1 : 0;
        return (1 - bit) == 1;
    }
}```