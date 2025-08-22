// Sum of Good Numbers
namespace CompetitiveProgramming.LeetCode.SumofGoodNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumOfGoodNumbers(int[] nums, int k)
    {
        int len = nums.Length, sum = 0;
        for(int i = 0; i < len; i++)
        {
            if(i - k >= 0 && nums[i] <= nums[i-k] || i + k < len && nums[i] <= nums[i+k])
                continue;

            sum += nums[i];
        }

        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[] nums1 = {1, 3, 2, 1, 5, 4};
        int k1 = 2;
        int[] nums2 = {2, 1};
        int k2 = 1;
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SumOfGoodNumbers(nums1, k1), 12),
            ResultTester.CheckResult<int>(solution.SumOfGoodNumbers(nums2, k2), 2)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Good Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}