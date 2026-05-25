Problem Statement:

Given an integer N, return the number of digits in N.



Example 1:

Input:

N = 12345

Output:5

Explanation:  The number 12345 has 5 digits.
	
	
Example 2:

Input:

N = 7789                

Output: 4

Explanation: The number 7789 has 4 digits. 



```cs

// Brute Force Approch
public class CountDigitInNumber()
{
    public int CountDigits(int n)
    {
        if (n == 0) return 1;
        int count = 0;
        int number = Math.Abs(n);
        while (number > 0)
        {
            count += 1;
            number /= 10; // remove last digit
        }
        return count;
    }
}

// String Approch
public class CountDigitInNumberString()
{
    public int CountDigits(int n)
    {
        int number = Math.Abs(n);
        string s = number.ToString();
        return s.Length;
    }
}

// Logarithm Approch
public class CountDigitInNumberLogarithm()
{
    public int CountDigits(int n)
    {
        if (n == 0) return 1;
        double absoluteNumber = Math.Abs(n); // absolute value for negative numbers
        return (int)Math.Floor(Math.Log10(absoluteNumber)) + 1; // log10 formula
    }
}
```