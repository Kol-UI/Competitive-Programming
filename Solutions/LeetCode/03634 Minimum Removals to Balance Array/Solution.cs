// Minimum Removals to Balance Array
namespace CompetitiveProgramming.LeetCode.MinimumRemovalstoBalanceArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinRemoval(int[] nums, int k)
    {
        Array.Sort(nums);
        int l = 0, r = 0, ans = int.MaxValue;
        while (l < nums.Length && r < nums.Length)
        {
            long temp = ((long)nums[l]) * k;
            if (temp >= nums[r])
            {
                r++;
                ans = Math.Min(ans, nums.Length - (r - l));
            }
            else
            {
                l++;
            }
        }
        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinRemoval([2,1,5], 2), 1),
            ResultTester.CheckResult<int>(solution.MinRemoval([1,6,2,9], 3), 2),
            ResultTester.CheckResult<int>(solution.MinRemoval([4,6], 2), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Removals to Balance Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}