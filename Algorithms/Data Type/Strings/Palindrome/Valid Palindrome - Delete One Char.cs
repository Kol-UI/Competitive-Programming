namespace CompetitiveProgramming.Algorithms;
// Given a string, check if it could be a palindrome after
// deleting at most one character.
// Example: "abca" -> true (delete 'b' or 'c')
// "abc" -> false
// "aba" -> true
// "cbbcc" -> true
// "a" -> true
// "" -> true

public class ValidPalindromeDeleteOneChar
{
    // Approach 1: Two pointers, skip one mismatch
    public bool ValidPalindromeTwoPointers(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                // try skipping either the left or the right char
                return IsPalindromeRange(s, left + 1, right) ||
                       IsPalindromeRange(s, left, right - 1);
            }

            left++;
            right--;
        }

        return true;
    }

    private bool IsPalindromeRange(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    // Approach 2: Brute force, try deleting each char once
    public bool ValidPalindromeBruteForce(string s)
    {
        if (IsFullPalindrome(s))
            return true;

        for (int i = 0; i < s.Length; i++)
        {
            string candidate = s.Remove(i, 1);

            if (IsFullPalindrome(candidate))
                return true;
        }

        return false;
    }

    private bool IsFullPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}