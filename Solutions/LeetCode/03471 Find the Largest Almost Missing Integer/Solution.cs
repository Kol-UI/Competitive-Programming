// Find the Largest Almost Missing Integer
namespace CompetitiveProgramming.LeetCode.FindtheLargestAlmostMissingInteger;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LargestInteger(int[] nums, int k) => nums.Length == k
        ? nums.Max()
        : k == 1
            ? nums.GroupBy(m => m).
                Where(m => m.Count() <= 1).
                Select(n => n.Key).
                DefaultIfEmpty(-1).
                Max()
            : Math.Max(
                nums.Count(m => m == nums[0]) <= 1 ? nums[0] : -1,
                nums.Count(m => m == nums[^1]) <= 1 ? nums[^1] : -1
                );
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LargestInteger([3,9,2,1,7], 3), 7),
            ResultTester.CheckResult<int>(solution.LargestInteger([3,9,7,2,1,7], 4), 3),
            ResultTester.CheckResult<int>(solution.LargestInteger([0,0], 1), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Largest Almost Missing Integer");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}