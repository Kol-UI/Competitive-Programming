// Maximize Expression of Three Elements
namespace CompetitiveProgramming.LeetCode.MaximizeExpressionofThreeElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximizeExpressionOfThree(int[] nums)
    {
        Array.Sort(nums);
        return (nums[nums.Length - 1]) + (nums[nums.Length - 2]) - nums[0];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaximizeExpressionOfThree([1,4,2,5]), 8),
            ResultTester.CheckResult<int>(solution.MaximizeExpressionOfThree([-2,0,5,-2,4]), 11),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Expression of Three Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}