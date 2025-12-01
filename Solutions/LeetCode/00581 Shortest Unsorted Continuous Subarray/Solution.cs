// Shortest Unsorted Continuous Subarray
namespace CompetitiveProgramming.LeetCode.ShortestUnsortedContinuousSubarray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindUnsortedSubarray(int[] nums)
    {
        int n = nums.Length;
        int start = -1, end = -1;

        int maxSeen = int.MinValue, minSeen = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            maxSeen = Math.Max(maxSeen, nums[i]);
            if (nums[i] < maxSeen)
            {
                end = i;
            }
        }

        for (int i = n - 1; i >= 0; i--)
        {
            minSeen = Math.Min(minSeen, nums[i]);
            if (nums[i] > minSeen)
            {
                start = i;
            }
        }

        if (start == -1)
        {
            return 0;
        }

        return end - start + 1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.FindUnsortedSubarray([2,6,4,8,10,9,15]), 5),
            ResultTester.CheckResult<int>(solution.FindUnsortedSubarray([1,2,3,4]), 0),
            ResultTester.CheckResult<int>(solution.FindUnsortedSubarray([1]), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest Unsorted Continuous Subarray");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}