// Percentage of Letter in String
namespace CompetitiveProgramming.LeetCode.PercentageofLetterinString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int PercentageLetter(string s, char letter) => 100 * s.Count(x => x == letter) / s.Length;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.PercentageLetter("foobar", 'o'), 33),
            ResultTester.CheckResult<int>(solution.PercentageLetter("jjjj", 'k'), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Percentage of Letter in String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}