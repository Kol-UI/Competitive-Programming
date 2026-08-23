Valid Palindrome


Given a string s, return true if it is a palindrome, otherwise return false.

A palindrome is a string that reads the same forward and backward.

It is also case-insensitive and ignores all non-alphanumeric characters.

Note: Alphanumeric characters consist of letters (A-Z, a-z) and numbers (0-9).


Example 1:

Input: s = "Was it a car or a cat I saw?"

Output: true

Explanation: After considering only alphanumerical characters we have "wasitacaroracatisaw", which is a palindrome.


Example 2:

Input: s = "tab a cat"

Output: false

Explanation: "tabacat" is not a palindrome.



```cs

// Reverse String Method
public class ValidPalindromeReverseString()
{
    public bool IsPalindrome(string s)
    {
        string newStr = "";
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                newStr += char.ToLower(c);
            }
        }
        return newStr == new string(newStr.Reverse().ToArray());
    }
}

// Two Pointers Method
public class ValidPalindromeTwoPointers()
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while (right > left && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
```