// Minimum Size Subarray in Infinite Array
namespace CompetitiveProgramming.LeetCode.MinimumSizeSubarrayinInfiniteArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinSizeSubarray(int[] nums, int target)
    {
        var totalNums = 0;
        foreach (var num in nums)
        {
            totalNums += num;
        }
        var div = target / totalNums;
        target = target % totalNums;
        var q = new Queue<int>();
        var sum = 0;
        var minCnt = Int32.MaxValue;
        for (var i = 0; i < nums.Length * 2; i++)
        {
            q.Enqueue(nums[i % nums.Length]);
            sum += nums[i % nums.Length];
            if (sum < target)
            {
                continue;
            }
            if (sum == target)
            {
                minCnt = minCnt > q.Count ? q.Count : minCnt;
            }
            while (sum > target)
            {
                q.TryDequeue(out int val);
                sum -= val;
            }
            if (sum == target)
            {
                minCnt = minCnt > q.Count ? q.Count : minCnt;
            }
        }
        return minCnt == Int32.MaxValue ? -1 : minCnt + div * nums.Length;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinSizeSubarray([1,2,3], 5), 2),
            ResultTester.CheckResult<int>(solution.MinSizeSubarray([1,1,1,2,3], 4), 2),
            ResultTester.CheckResult<int>(solution.MinSizeSubarray([2,4,6,8], 3), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Size Subarray in Infinite Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}