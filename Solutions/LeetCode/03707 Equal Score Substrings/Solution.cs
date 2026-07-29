// Equal Score Substrings
namespace CompetitiveProgramming.LeetCode.EqualScoreSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ScoreBalance(string s)
    {
        var sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sum += (int)s[i] - (int)'a' + 1;
        }
        if (sum % 2 == 1) return false;
        var halfSum = sum / 2;
        sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sum += (int)s[i] - (int)'a' + 1;
            if (sum == halfSum) return true;
            if (sum > halfSum) break;
        }
        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.ScoreBalance("adcb"), true),
            ResultTester.CheckResult<bool>(solution.ScoreBalance("bace"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Equal Score Substrings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}