// Find the Maximum Number of Marked Indices
namespace CompetitiveProgramming.LeetCode.FindtheMaximumNumberofMarkedIndices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxNumOfMarkedIndices(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        int first = 0, second = (nums.Length + 1) / 2;

        while (second < n)
        {
            if (nums[first] * 2 <= nums[second])
                first++;

            second++;
        }

        return first * 2;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxNumOfMarkedIndices([3,5,2,4]), 2),
            ResultTester.CheckResult<int>(solution.MaxNumOfMarkedIndices([9,2,5,4]), 4),
            ResultTester.CheckResult<int>(solution.MaxNumOfMarkedIndices([7,6,8]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Maximum Number of Marked Indices");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}