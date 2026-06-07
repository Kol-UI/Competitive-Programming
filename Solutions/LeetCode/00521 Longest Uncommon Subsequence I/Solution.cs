// Longest Uncommon Subsequence I
namespace CompetitiveProgramming.LeetCode.LongestUncommonSubsequenceI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindLUSlength(string a, string b)
    {
        if (a == b) return -1;
        return Math.Max(a.Length, b.Length);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.FindLUSlength("aba", "cdc"), 3),
            ResultTester.CheckResult<int>(solution.FindLUSlength("aaa", "bbb"), 3),
            ResultTester.CheckResult<int>(solution.FindLUSlength("aaa", "aaa"), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Uncommon Subsequence I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}