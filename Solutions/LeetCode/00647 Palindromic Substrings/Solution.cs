// Palindromic Substrings


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PalindromicSubstrings
{
    public class Solution
    {
        public static int CountSubstrings(string s)
        {
            int count = 0;
            int n = s.Length;

            for (int center = 0; center < 2 * n - 1; center++)
            {
                int left = center / 2;
                int right = left + center % 2;

                while (left >= 0 && right < n && s[left] == s[right])
                {
                    count++;
                    left--;
                    right++;
                }
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountSubstrings("abc"), 3),
                ResultTester.CheckResult<int>(Solution.CountSubstrings("aaa"), 6),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindromic Substrings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}