Invert sign of a given number
```cs
public class InvertNumber
{
    // Multiplication Approach
    public static int InvertSignMath(int number)
    {
        return number * -1;
    }

    // Bitwise Approach
    public static int InvertSignBitwise(int number)
    {
        // Flip all bits and add one
        return ~number + 1;
    }
}```