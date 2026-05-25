Problem Statement:

Given an integer N, return true if it is a palindrome else return false.


A palindrome is a number that reads the same backward as forward.

For example, 121, 1331, and 4554 are palindromes because they remain the same when their digits are reversed.



Example 1:

Input:N = 4554

Output:Palindrome Number

Explanation: The reverse of 4554 is 4554 and therefore it is palindrome number


Example 2:

Input:N = 7789                

Output: Not Palindrome

Explanation: The reverse of number 7789 is 9877 and therefore it is not palindrome



```cs
public class CheckifanumberisPalindromeorNot()
{
    public bool IsPalindrome(int n)
    {
        if (n < 0) return false;
        int revNum = 0;
        int dup = n;
        while (n > 0)
        {
            int ld = ExtractLastDigit(n);
            revNum = ShiftAndAppend(revNum, ld);
            n = RemoveLastDigit(n);
        }
        if (dup == revNum) return true;
        else return false;
    }

    public int ExtractLastDigit(int n) => n % 10;
    public int RemoveLastDigit(int n) => n / 10;
    public int ShiftAndAppend(int n, int lastDigitToAppend)
    {
        bool isNegative = n < 0;
        int absN = Math.Abs(n);
        int result = (absN * 10) + lastDigitToAppend;
        return isNegative ? -result : result;
    }
}
```