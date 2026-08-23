Problem Statement:

Given an integer N return the reverse of the given number.



Note: 

If a number has trailing zeros, then its reverse will not include them.

For e.g., reverse of 10400 will be 401 instead of 00401.



Example 1:

Input: N = 12345

Output: 54321

Explanation: The reverse of 12345 is 54321.


Example 2:

Input: N = 7789        

Output: 9877

Explanation: The reverse of number 7789 is 9877.


```cs

public class ReverseDigitsofANumber()
{
    // String Approch
    public int ReverseDigitsString(int n)
    {
        bool isNegative = n < 0;
        string numberAsString = Math.Abs(n).ToString();

        char[] charArray = numberAsString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new(charArray);

        int reversedNum = int.Parse(reversedString);

        return isNegative ? -reversedNum : reversedNum;
    }

    // Math Approch
    public int ReverseDigits(int n)
    {
        bool isNegative = n < 0;
        long number = Math.Abs((long)n);
        long reversedNum = 0;
        
        while (number > 0)
        {
            long lastDigit = number % 10;
            // We shift all the digits of 'reversedNum' one position to the left (by multiplying by 10)
            // and then we add the new last digit ('lastDigit').
            reversedNum = (reversedNum * 10) + lastDigit;
            number /= 10; 
        }

        if (isNegative) return (int)-reversedNum;        
        return (int)reversedNum;
    }
}
```