Check if an int is an armstrong number and returns the value. 407 is given as input. 4 * 4 * 4 + 0 * 0 * 0 + 7 * 7 * 7 = 407 is an armstrong number.

```cs
public class ArmstrongNumber
{
    // Approach 1 : Extract Digits with modulo, raise to power d (d = number of digits)
    public bool IsArmstrongLoop(int n, out int result)
    {
        int digits = (int)Math.Floor(Math.Log10(n) + 1);
        int sum = 0, temp = n;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }
        result = sum;
        return sum == n;
    }

    // Approach 2 : LINQ - string representation of n
    public bool IsArmstrongLinq(int n, out int result)
    {
        string s = n.ToString();
        int digits = s.Length;
        result = s.Sum(c => (int)Math.Pow(c - '0', digits));
        return result == n;
    }

    // Approach 3 : Recursive - accumulates the sum
    public bool IsArmstrongRecursive(int n, out int result)
    {
        int digits = (int)Math.Floor(Math.Log10(n) + 1);
        result = SumOfPowers(n, digits);
        return result == n;
    }

    private int SumOfPowers(int n, int digits)
    {
        if (n == 0) return 0;
        int digit = n % 10;
        return (int)Math.Pow(digit, digits) + SumOfPowers(n / 10, digits);
    }
}```