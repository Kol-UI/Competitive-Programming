namespace CompetitiveProgramming.Algorithms;

public class DigitManipulation()
{
    public static int ExtractLastDigit(int n) => n % 10;
    public static int RemoveLastDigit(int n) => n / 10;
    public static int ShiftAndAppend(int n, int lastDigitToAppend)
    {
        bool isNegative = n < 0;
        int absN = Math.Abs(n);
        int result = (absN * 10) + lastDigitToAppend;
        return isNegative ? -result : result;
    }

    public static int ReverseDigitsString(int n)
    {
        bool isNegative = n < 0;
        string numberAsString = Math.Abs(n).ToString();

        char[] charArray = numberAsString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new(charArray);

        int reversedNum = int.Parse(reversedString);

        return isNegative ? -reversedNum : reversedNum;
    }

    public static int ReverseDigits(int n)
    {
        bool isNegative = n < 0;
        long number = Math.Abs((long)n);
        long reversedNum = 0;

        while (number > 0)
        {
            long lastDigit = number % 10;
            reversedNum = (reversedNum * 10) + lastDigit;
            number /= 10;
        }

        if (isNegative) return (int)-reversedNum;
        return (int)reversedNum;
    }

    #region Count Digits
    // 123 = 3 digits
    public static int CountDigitsBruteForce(int n)
    {
        if (n == 0) return 1;
        int count = 0;
        int number = Math.Abs(n);
        while (number > 0)
        {
            count += 1;
            number /= 10;
        }
        return count;
    }

    public static int CountDigitsString(int n)
    {
        int number = Math.Abs(n);
        string s = number.ToString();
        return s.Length;
    }

    public static int CountDigitsLogarithm(int n)
    {
        if (n == 0) return 1;
        double absoluteNumber = Math.Abs(n); // absolute value for negative numbers
        return (int)Math.Floor(Math.Log10(absoluteNumber)) + 1; // log10 formula
    }
    #endregion
}