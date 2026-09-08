// Distinct Subsequences
namespace CompetitiveProgramming.LeetCode.DistinctSubsequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumDistinct(string s, string t)
    {
        var opt = new int[t.Length, s.Length];
        if (s[0] == t[0])
            opt[0, 0] = 1;
        for (int i = 1; i < s.Length; i++)
        {
            opt[0, i] = opt[0, i - 1];
            if (s[i] == t[0])
                opt[0, i]++;
        }
        for (int row = 1; row < t.Length; row++)
            for (int col = 1; col < s.Length; col++)
            {
                opt[row, col] = opt[row, col - 1];
                if (t[row] == s[col])
                    opt[row, col] += opt[row - 1, col - 1];
            }
        return opt[t.Length - 1, s.Length - 1];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumDistinct("rabbbit", "rabbit"), 3),
            ResultTester.CheckResult<int>(solution.NumDistinct("babgbag", "bag"), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Distinct Subsequences");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}