// Valid Palindrome II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidPalindromeII
{
    public class Solution
    {
        public bool ValidPalindrome(string s) 
        {
            var (isPalindrome, left, right) = IsPalindrome(s, 0, s.Length - 1);

            if (isPalindrome) 
            {
                return true;
            }

            return IsPalindrome(s, left + 1, right).isPalindrome || IsPalindrome(s, left, right - 1).isPalindrome;
        }

        private (bool isPalindrome, int left, int right) IsPalindrome(string s, int left, int right) 
        {
            while (left < right) 
            {
                if (s[left] != s[right]) 
                {
                    return (false, left, right);
                }

                left++;
                right--;
            }

            return (true, left, right);
        }
    }

    public class Solution2
    {
        public bool ValidPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
                }
            }
            return true;
        }

        private bool IsPalindrome(string s, int left, int right)
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
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Palindrome II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}