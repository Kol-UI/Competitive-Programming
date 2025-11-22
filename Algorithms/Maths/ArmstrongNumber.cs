namespace CompetitiveProgramming.Algorithms;

public class ArmstrongNumber()
{
    /*
        Sum Formula : n[0]^k + n[1]^k + n[2]^k until last digit
        For 1-digit numbers (0–9), all are Armstrong numbers, so there are 10 such numbers.
        For 2-digit numbers (10–99), none of them are Armstrong numbers.
        For 3-digit numbers (100–999), there are 5 Armstrong numbers: 153, 370, 371, 407, and 0.
        For 4-digit numbers (1000–9999), there are 7 Armstrong numbers: 1634, 8208, 9474, and a few others.
    */
    public static bool IsArmstrongNumber(int n)
    {
        if (n < 0) return false;
        int armstrongSum = CalculateArmstrongSum(n);
        return n == armstrongSum;
    }

    public static int CalculateArmstrongSum(int n)
    {
        if (n < 0) return 0;
        int originalNumber = n;
        int k = CountDigits(originalNumber);
        int sum = 0;

        while (originalNumber > 0)
        {
            int lastDigit = ExtractLastDigit(originalNumber);
            sum += (int)Math.Pow(lastDigit, k); 
            originalNumber = RemoveLastDigit(originalNumber);
        }

        return sum;
    }

    private static int ExtractLastDigit(int n) => n % 10;
    private static int RemoveLastDigit(int n) => n / 10;
    private static int CountDigits(int n)
    {
        if (n == 0) return 1;
        double absoluteNumber = Math.Abs(n);
        return (int)Math.Floor(Math.Log10(absoluteNumber)) + 1;
    }
}