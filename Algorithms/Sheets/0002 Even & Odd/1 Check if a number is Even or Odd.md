
Check if a number is Even or Odd

```cs
public class EvenOrOdd
{
    public static string IsEvenOrOdd(int number)
    {
        // We use the modulo operator %
        // A number is even if the remainder of its division by 2 is 0
        if (number % 2 == 0) return "Even";
        return "Odd";
    }

    // Boolean version
    public static bool IsEven(int number) => number % 2 == 0;
}
```