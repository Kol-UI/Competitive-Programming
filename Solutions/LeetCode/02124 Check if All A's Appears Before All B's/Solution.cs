// Check if All A's Appears Before All B's
namespace CompetitiveProgramming.LeetCode.CheckifAllAsAppearsBeforeAllBs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckString(string s) => s.IndexOf('b') != -1 ? s.LastIndexOf('a') < s.IndexOf('b') : true;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CheckString("aaabbb"), true),
            ResultTester.CheckResult<bool>(solution.CheckString("abab"), false),
            ResultTester.CheckResult<bool>(solution.CheckString("bbb"), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if All A's Appears Before All B's");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}