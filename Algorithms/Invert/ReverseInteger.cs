namespace CompetitiveProgramming.Algorithms;

public class ReverseInteger
{
    // Math approach: pop last digit, push into result, check overflow each step
    public int ReverseMath(int x)
    {
        long result = 0;
        int n = x;

        while (n != 0)
        {
            int digit = n % 10;
            n /= 10;
            result = result * 10 + digit;

            if (result > int.MaxValue || result < int.MinValue)
                return 0;
        }

        return (int)result;
    }

    // String approach: reverse digit characters, keep sign, check overflow
    public int ReverseString(int x)
    {
        bool isNegative = x < 0;
        string digits = Math.Abs((long)x).ToString();

        char[] arr = digits.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        if (!long.TryParse(reversed, out long value))
            return 0;

        if (isNegative)
            value = -value;

        if (value > int.MaxValue || value < int.MinValue)
            return 0;

        return (int)value;
    }
}