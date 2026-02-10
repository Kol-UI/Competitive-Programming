// Longest Balanced Subarray I
namespace CompetitiveProgramming.LeetCode.LongestBalancedSubarrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestBalanced(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var even = new HashSet<int>();
            var odd = new HashSet<int>();
            for (int k = i; k < nums.Length; k++)
            {
                if (nums[k] % 2 == 0)
                    even.Add(nums[k]);
                else
                    odd.Add(nums[k]);

                if (even.Count() == odd.Count())
                    result = Math.Max(result, k - i + 1);
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LongestBalanced([2,5,4,3]), 4),
            ResultTester.CheckResult<int>(solution.LongestBalanced([3,2,2,5,4]), 5),
            ResultTester.CheckResult<int>(solution.LongestBalanced([1,2,3,2]), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Balanced Subarray I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}