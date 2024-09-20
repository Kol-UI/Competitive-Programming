// Shortest Palindrome

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestPalindrome
{
    public class Solution
    {
        public string ShortestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            
            int palindromeEnd = FindLongestPalindromeFromStart(s);
            string remaining = s.Substring(palindromeEnd + 1);
            string reversedRemaining = ReverseString(remaining);
            
            return BuildShortestPalindrome(reversedRemaining, s);
        }

        private int FindLongestPalindromeFromStart(string s)
        {
            int end = s.Length - 1;
            int start = 0;
            while (end >= 0)
            {
                if (IsPalindrome(s, start, end))
                {
                    return end;
                }
                end--;
            }
            return 0;
        }

        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }

        private string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private string BuildShortestPalindrome(string prefix, string original)
        {
            return prefix + original;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.ShortestPalindrome("aacecaaa"), "aaacecaaa"),
                ResultTester.CheckResult<string>(solution.ShortestPalindrome("abcd"), "dcbabcd"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Palindrome");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}