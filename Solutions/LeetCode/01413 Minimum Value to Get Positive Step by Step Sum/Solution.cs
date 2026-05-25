// Minimum Value to Get Positive Step by Step Sum
namespace CompetitiveProgramming.LeetCode.MinimumValuetoGetPositiveStepbyStepSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinStartValue(int[] nums)
    {
        int minSum = 0, sum = 0;

        foreach (int num in nums)
            minSum = Math.Min(minSum, sum += num);
            
        return 1 - minSum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinStartValue([-3,2,-3,4,2]), 5),
            ResultTester.CheckResult<int>(solution.MinStartValue([1,2]), 1),
            ResultTester.CheckResult<int>(solution.MinStartValue([1,-2,-3]), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Value to Get Positive Step by Step Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}