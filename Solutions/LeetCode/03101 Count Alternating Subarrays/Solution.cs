// Count Alternating Subarrays
namespace CompetitiveProgramming.LeetCode.CountAlternatingSubarrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountAlternatingSubarrays(int[] nums)
    {
        long result = 0;

        for (int i = nums.Length - 1, current = 0; i >= 0; --i)
            result += current = i == nums.Length - 1 || nums[i] == nums[i + 1] ? 1 : current + 1;

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.CountAlternatingSubarrays([0,1,1,1]), 5),
            ResultTester.CheckResult<long>(solution.CountAlternatingSubarrays([1,0,1,0]), 10),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Alternating Subarrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}