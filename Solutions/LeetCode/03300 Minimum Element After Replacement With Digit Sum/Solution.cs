// Minimum Element After Replacement With Digit Sum
namespace CompetitiveProgramming.LeetCode.MinimumElementAfterReplacementWithDigitSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinElement(int[] nums) => nums
        .Select(n => n.ToString()
            .ToCharArray().Sum(n => (int)char.GetNumericValue(n))). Min();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinElement([10,12,13,14]), 1),
            ResultTester.CheckResult<int>(solution.MinElement([1,2,3,4]), 1),
            ResultTester.CheckResult<int>(solution.MinElement([999,19,199]), 10)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Element After Replacement With Digit Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}