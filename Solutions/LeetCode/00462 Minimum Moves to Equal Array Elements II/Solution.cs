// Minimum Moves to Equal Array Elements II
namespace CompetitiveProgramming.LeetCode.MinimumMovestoEqualArrayElementsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinMoves2(int[] nums) => nums.Aggregate((0, nums.OrderBy(m => m).ElementAtOrDefault(nums.Length / 2)), (acum, curr) => (
        acum.Item1 + Math.Abs(curr - acum.Item2),
        acum.Item2
    ), m => m.Item1);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinMoves2([1,2,3]), 2),
            ResultTester.CheckResult<int>(solution.MinMoves2([1,10,2,9]), 16),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Moves to Equal Array Elements II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}