// Transformed Array
namespace CompetitiveProgramming.LeetCode.TransformedArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ConstructTransformedArray(int[] nums) => nums.
        Select((m, i) => (m + i) % nums.Length).
        Select(m => nums[m >= 0 ? m : m + nums.Length]).
        ToArray();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ConstructTransformedArray([3,-2,1,1]), [1,1,1,3]),
            ResultTester.CheckResult<int[]>(solution.ConstructTransformedArray([-1,4,-1]), [-1,-1,4]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Transformed Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}