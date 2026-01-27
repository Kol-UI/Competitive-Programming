// Visit Array Positions to Maximize Score
namespace CompetitiveProgramming.LeetCode.VisitArrayPositionstoMaximizeScore;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxScore(int[] nums, int x)
    {
        int len = nums.Length;
        long[] result = new long[2];
        result[nums[0] % 2] = nums[0];
        result[(nums[0] + 1) % 2] = nums[0] - x;

        for (int i = 1; i < len; i++)
        {
            long cur = nums[i];
            if (cur % 2 == 0)
                result[0] = Math.Max(result[0], result[1] - x) + cur;
            else
                result[1] = Math.Max(result[0] - x, result[1]) + cur;
        }

        return Math.Max(result[0], result[1]);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxScore([2,3,6,1,9,2], 5), 13),
            ResultTester.CheckResult<long>(solution.MaxScore([2,4,6,8], 3), 20),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Visit Array Positions to Maximize Score");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}