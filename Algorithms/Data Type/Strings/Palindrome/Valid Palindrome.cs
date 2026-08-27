using System.Text;

namespace CompetitiveProgramming.Algorithms;
// Given a string, check if it is a palindrome considering only
// alphanumeric characters and ignoring case.
// Example: "A man, a plan, a canal: Panama" -> true
public class ValidPalindrome
{
    // Approach 1: Two pointers
    public bool IsPalindromeTwoPointers(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // skip non-alphanumeric chars
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;
            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }

    // Approach 2: Filter + build string, then compare with reverse
    public bool IsPalindromeFilterAndReverse(string s)
    {
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
                sb.Append(char.ToLower(c));
        }

        string cleaned = sb.ToString();
        string reversed = new string(cleaned.Reverse().ToArray());

        return cleaned == reversed;
    }
}