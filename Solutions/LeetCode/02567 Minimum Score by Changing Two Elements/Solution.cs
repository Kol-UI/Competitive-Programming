// Minimum Score by Changing Two Elements
namespace CompetitiveProgramming.LeetCode.MinimumScorebyChangingTwoElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimizeSum(int[] nums)
    {
        Array.Sort(nums);
        return Math.Min(nums[^3] - nums[0], Math.Min(nums[^1] - nums[2], nums[^2] - nums[1]));
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimizeSum([1,4,7,8,5]), 3),
            ResultTester.CheckResult<int>(solution.MinimizeSum([1,4,3]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Score by Changing Two Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}