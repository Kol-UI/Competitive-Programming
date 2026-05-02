// Rotate Function
namespace CompetitiveProgramming.LeetCode.RotateFunction;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxRotateFunction(int[] nums)
    {
        var (rs, sum) = CalculateInitData(nums);
        var rs0 = rs;
        for (int i = 1; i < nums.Length; i++)
        {
            rs0 += -sum + nums[i - 1] * nums.Length;
            rs = Math.Max(rs, rs0);
        }
        return rs;
    }

    private (int rs, int sum) CalculateInitData(int[] nums)
    {
        var sum = nums[0];
        var rs = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            rs += i * nums[i];
            sum += nums[i];
        }
        return (rs, sum);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxRotateFunction([4,3,2,6]), 26),
            ResultTester.CheckResult<int>(solution.MaxRotateFunction([100]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rotate Function");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}