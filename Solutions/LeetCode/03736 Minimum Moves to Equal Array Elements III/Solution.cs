// Minimum Moves to Equal Array Elements III
namespace CompetitiveProgramming.LeetCode.MinimumMovestoEqualArrayElementsIII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinMoves(int[] nums)
    {
        int max = nums[0];
        foreach (int x in nums)
        {
            max = Math.Max(max, x);
        }
        int result = 0;
        foreach (int x in nums)
        {
            result += max - x;
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinMoves([2,1,3]), 3),
            ResultTester.CheckResult<int>(solution.MinMoves([4,4,5]), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Moves to Equal Array Elements III");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}