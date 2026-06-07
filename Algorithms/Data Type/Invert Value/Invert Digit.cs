namespace CompetitiveProgramming.Algorithms;
public class InvertDigit
{
    // Maths Approach
    public static int ReverseDigits(int number)
    {
        int reverse = 0;
        // Process until every digit has been moved
        while (number != 0)
        {
            // Extract the last digit using the remainder operator
            // 123 % 10 = 3
            int lastDigit = number % 10;
            // Shift existing digits one place to the left (multiply by 10)
            // then add the extracted digit
            // (0 * 10) + 3 = 3 -> (3 * 10) + 2 = 32...
            reverse = (reverse * 10) + lastDigit;
            // Remove the last digit from the original number by using integer division
            // 123 / 10 = 12
            number /= 10;
        }

        return reverse;
    }

    // Array Swapping Approach
    public static int ReverseDigitsWithSwap(int number)
    {
        // Handle negative numbers by storing the sign
        bool isNegative = number < 0;
        // Convert to absolute string and then to a character array
        // -123 -> "123" -> ['1', '2', '3']
        char[] digits = Math.Abs(number).ToString().ToCharArray();
        int left = 0;
        int right = digits.Length - 1;
        // Swap
        while (left < right)
        {
            (digits[right], digits[left]) = (digits[left], digits[right]);
            left++;
            right--;
        }
        string reversedStr = new(digits);
        int result = int.Parse(reversedStr);
        // Re-apply the sign if necessary
        return isNegative ? -result : result;
    }
}