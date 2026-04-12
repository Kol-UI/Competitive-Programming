// Reverse String Prefix
namespace CompetitiveProgramming.LeetCode.ReverseStringPrefix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ReversePrefix(string s, int k) =>
        string.Concat(s.Take(k).Reverse().Concat(s.Skip(k)));
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.ReversePrefix("abcd", 2), "bacd"),
            ResultTester.CheckResult<string>(solution.ReversePrefix("xyz", 3), "zyx"),
            ResultTester.CheckResult<string>(solution.ReversePrefix("hey", 1), "hey"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reverse String Prefix");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}