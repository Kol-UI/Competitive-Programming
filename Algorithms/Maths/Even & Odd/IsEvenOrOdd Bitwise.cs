namespace CompetitiveProgramming.Algorithms;
public class EvenOrOddBitWise
{
    /*
        In binary, all even numbers end in 0 and all odd numbers end in 1.

            2 in binary: 0010 (ends in 0)

            3 in binary: 0011 (ends in 1)

            10 in binary: 1010 (ends in 0)

        To verify this, we use the AND operator (&) with the digit 1. If the result is 0, the number is even.

        We compare the number with 1 (binary mask 0001)

        If the last bit is 0, (number & 1) will equal 0
    */
    public static string IsEvenOrOdd(int number)
    {
        if ((number & 1) == 0)
        {
            return "Even";
        }
        
        return "Odd";
    }

    public static bool IsEven(int number) => (number & 1) == 0;
}