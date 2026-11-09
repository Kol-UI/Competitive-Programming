// Count Subarrays With Loose Bounds
namespace CompetitiveProgramming.LeetCode.CountSubarraysWithLooseBounds;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CountSubarrays(int[] nums, int minK, int maxK) => nums.
        Aggregate((0L, 0L), (acum, curr) => (
            acum.Item1 + (curr >= minK && curr <= maxK ? acum.Item2 + 1 : 0),
            curr >= minK && curr <= maxK ? acum.Item2 + 1 : 0
        ), m => m.Item1);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.CountSubarrays([1,4,7,3], 1, 5), 4),
            ResultTester.CheckResult<long>(solution.CountSubarrays([1,1], 1, 1), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Subarrays With Loose Bounds");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}