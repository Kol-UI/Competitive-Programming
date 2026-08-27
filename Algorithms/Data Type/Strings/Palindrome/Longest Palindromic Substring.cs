namespace CompetitiveProgramming.Algorithms;
// Given a string, find the longest substring that is a palindrome.
// Example: "babad" -> "bab" or "aba" (both valid)
public class LongestPalindromicSubstring
{
    // Approach 1: Expand around center
    public string LongestPalindromeExpandAroundCenter(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            // odd length palindromes (single center)
            int len1 = ExpandFromCenter(s, i, i);
            // even length palindromes (double center)
            int len2 = ExpandFromCenter(s, i, i + 1);

            int len = Math.Max(len1, len2);

            if (len > maxLength)
            {
                maxLength = len;
                start = i - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);
    }

    private int ExpandFromCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        // length of the palindrome found
        return right - left - 1;
    }

    // Approach 2: Dynamic programming
    public string LongestPalindromeDynamicProgramming(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        int n = s.Length;
        bool[,] dp = new bool[n, n];

        int start = 0;
        int maxLength = 1;

        // every single char is a palindrome
        for (int i = 0; i < n; i++)
            dp[i, i] = true;

        // check substrings by increasing length
        for (int length = 2; length <= n; length++)
        {
            for (int i = 0; i <= n - length; i++)
            {
                int j = i + length - 1;

                if (s[i] != s[j])
                    continue;

                // length 2, or inner substring is already a palindrome
                dp[i, j] = length == 2 || dp[i + 1, j - 1];

                if (dp[i, j] && length > maxLength)
                {
                    start = i;
                    maxLength = length;
                }
            }
        }

        return s.Substring(start, maxLength);
    }
}