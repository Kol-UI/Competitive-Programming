// Longest Palindromic Subsequence After at Most K Operations
namespace CompetitiveProgramming.LeetCode.LongestPalindromicSubsequenceAfteratMostKOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestPalindromicSubsequence(string s, int k)
    {
        if (s.Length < 2)
        {
            return s.Length;
        }

        var dp = new int[s.Length, s.Length + 1, k + 1];
        for (int x = 0; x < s.Length; x++)
        {
            dp[x, x + 1, 0] = 1;
        }

        for (int l = 2; l <= s.Length; l++)
        {
            for (int x = s.Length - l; x >= 0; x--)
            {
                dp[x, x + l, 0] = Math.Max(Math.Max(dp[x, x + l - 1, 0], dp[x + 1, x + l, 0]),
                                           s[x] == s[x + l - 1] ? dp[x + 1, x + l - 1, 0] + 2 : 0);
            }
        }

        for (int totalOps = 1; totalOps <= k; totalOps++)
        {
            for (int l = 2; l <= s.Length; l++)
            {
                for (int x = s.Length - l; x >= 0; x--)
                {
                    dp[x, x + l, totalOps] = Math.Max(Math.Max(dp[x, x + l - 1, totalOps], dp[x + 1, x + l, totalOps]), dp[x, x + l, totalOps - 1]);
                    if (dp[x, x + l, totalOps] == l)
                    {
                        continue;
                    }

                    for (int usedOps = 0; usedOps <= totalOps; usedOps++)
                    {
                        int remainingOp = totalOps - usedOps;
                        if (this.IsNear(s[x], s[x + l - 1], remainingOp))
                        {
                            dp[x, x + l, totalOps] = Math.Max(dp[x, x + l, totalOps], dp[x + 1, x + l - 1, usedOps] + 2);
                        }
                    }
                }
            }
        }

        return dp[0, s.Length, k];
    }

    private bool IsNear(char a, char b, int maxDiff)
    {
        var diff = Math.Abs(a - b);
        if (diff > 13)
        {
            diff = 26 - diff;
        }

        return diff <= maxDiff;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.LongestPalindromicSubsequence("abced", 2), 3),
            ResultTester.CheckResult<int>(solution.LongestPalindromicSubsequence("aaazzz", 4), 6),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Palindromic Subsequence After at Most K Operations");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}