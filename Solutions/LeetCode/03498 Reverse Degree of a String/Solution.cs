// Reverse Degree of a String
namespace CompetitiveProgramming.LeetCode.ReverseDegreeofaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ReverseDegree(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            result += (((s[i] - 'a') * -1) + 26) * (i + 1);
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ReverseDegree("abc"), 148),
            ResultTester.CheckResult<int>(solution.ReverseDegree("zaza"), 160),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reverse Degree of a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}