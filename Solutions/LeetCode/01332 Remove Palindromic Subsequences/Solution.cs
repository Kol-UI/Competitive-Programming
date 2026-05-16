// Remove Palindromic Subsequences
namespace CompetitiveProgramming.LeetCode.RemovePalindromicSubsequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int RemovePalindromeSub(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }

        return isPalindrome(s) ? 1 : 2;
    }

    private static bool isPalindrome(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.RemovePalindromeSub("ababa"), 1),
            ResultTester.CheckResult<int>(solution.RemovePalindromeSub("abb"), 2),
            ResultTester.CheckResult<int>(solution.RemovePalindromeSub("baabb"), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Palindromic Subsequences");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}