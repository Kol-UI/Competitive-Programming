// Largest Even Number
namespace CompetitiveProgramming.LeetCode.LargestEvenNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string LargestEven(string s) => s[..(s.LastIndexOf('2') + 1)];
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.LargestEven("1112"), "1112"),
            ResultTester.CheckResult<string>(solution.LargestEven("221"), "22"),
            ResultTester.CheckResult<string>(solution.LargestEven("1"), ""),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Even Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}