// Maximum Alternating Sum of Squares
namespace CompetitiveProgramming.LeetCode.MaximumAlternatingSumofSquares;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxAlternatingSum(int[] nums) => nums
        .OrderByDescending(x => Math.Abs(x))
        .Select((x, i) => i >= (nums.Length + 1) / 2 ? -(long)x * x : (long)x * x)
        .Sum();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxAlternatingSum([1,2,3]), 12),
            ResultTester.CheckResult<long>(solution.MaxAlternatingSum([1,-1,2,-2,3,-3]), 16),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Alternating Sum of Squares");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}