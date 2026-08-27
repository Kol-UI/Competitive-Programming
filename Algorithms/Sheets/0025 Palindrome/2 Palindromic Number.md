Palindromic Number

```cs
// Given an integer x, check if it is a palindrome.
// Negative numbers are never palindromes (because of the '-' sign).
// Example: 121 -> true, -121 -> false, 10 -> false
public class PalindromicNumber
{
    // Approach 1: Convert to string, compare with reversed string
    public bool IsPalindromeString(int x)
    {
        if (x < 0)
            return false;

        string s = x.ToString();
        string reversed = new string(s.Reverse().ToArray());

        return s == reversed;
    }

    // Approach 2: Pure numeric, reverse only half the number
    public bool IsPalindromeNumeric(int x)
    {
        // negative numbers and numbers ending with 0 (except 0 itself)
        // can't be palindromes
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        int reversedHalf = 0;

        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        // even digit count: x == reversedHalf
        // odd digit count: middle digit is dropped via /10
        return x == reversedHalf || x == reversedHalf / 10;
    }
}```