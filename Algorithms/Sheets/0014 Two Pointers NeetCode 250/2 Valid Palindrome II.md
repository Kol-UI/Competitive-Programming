
Valid Palindrome II

You are given a string s, return true if the s can be a palindrome after deleting at most one character from it.

A palindrome is a string that reads the same forward and backward.

Note: Alphanumeric characters consist of letters (A-Z, a-z) and numbers (0-9).


Example 1:

Input: s = "aca"

Output: true

Explanation: "aca" is already a palindrome.


Example 2:

Input: s = "abbadc"

Output: false

Explanation: "abbadc" is not a palindrome and can't be made a palindrome after deleting at most one character.


Example 3:

Input: s = "abbda"

Output: true

Explanation: "We can delete the character 'd'.



```cs
// Brute Force Method

public class ValidPalindromeIIBruteForce()
{
    public bool ValidPalindrome(string s)
    {
        if (IsPalindrome(s)) return true;
        for (int i = 0; i < s.Length; i++)
        {
            string newS = s.Substring(0, i) + s.Substring(i + 1);
            if (IsPalindrome(newS)) return true;
        }
        return false;
    }

    private bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}


// Two Pointers Method

public class ValidPalindromeIITwoPointers()
{
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                string skipL = s.Substring(left + 1, right - left);
                string skipR = s.Substring(left, right - left);
                return IsPalindrome(skipL) || IsPalindrome(skipR);
            }
            left++;
            right--;
        }
        return true;
    }

    private bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }
}
```