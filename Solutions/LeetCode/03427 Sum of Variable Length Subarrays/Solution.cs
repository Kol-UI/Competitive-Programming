// Sum of Variable Length Subarrays
namespace CompetitiveProgramming.LeetCode.SumofVariableLengthSubarrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SubarraySum(int[] nums)
    {
        int n = nums.Length;
        int sum = 0;
        for(int i = 0; i < n;i++)
        {
            int start = Math.Max(0, i - nums[i]);
            for(int j = start; j <= i;j++)
            {
                sum+=nums[j];
            }
        }
        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SubarraySum([2,3,1]), 11),
            ResultTester.CheckResult<int>(solution.SubarraySum([3,1,1,2]), 13),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Variable Length Subarrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}