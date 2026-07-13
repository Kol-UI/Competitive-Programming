// Maximum Total Subarray Value I
namespace CompetitiveProgramming.LeetCode.MaximumTotalSubarrayValueI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxTotalValue(int[] nums, int k)
    {
        long minv = long.MaxValue;
        long maxv = 0;
        for(int i = 0;i < nums.Count(); i++)
        {
            if(minv > nums[i]) minv = nums[i];
            if(maxv < nums[i]) maxv = nums[i];
        }
        return k*(maxv-minv);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxTotalValue([1,3,2], 2), 4),
            ResultTester.CheckResult<long>(solution.MaxTotalValue([4,2,5,1], 3), 12)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Total Subarray Value I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}