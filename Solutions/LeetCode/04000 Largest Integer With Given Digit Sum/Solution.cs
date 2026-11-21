// Largest Integer With Given Digit Sum
namespace CompetitiveProgramming.LeetCode.LargestIntegerWithGivenDigitSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LargestInteger(int n, int s) => s == 0 ? 0 : (s > 9 * n) ? -1 : Enumerable.Range(1, n).Select(i => Math.Max(Math.Min(s - 9 * (i - 1), 9), 0) * (int)Math.Pow(10, n - i)).Sum();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LargestInteger(2, 9), 90),
            ResultTester.CheckResult<int>(solution.LargestInteger(2, 19), -1),
            ResultTester.CheckResult<int>(solution.LargestInteger(5, 0), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Integer With Given Digit Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}