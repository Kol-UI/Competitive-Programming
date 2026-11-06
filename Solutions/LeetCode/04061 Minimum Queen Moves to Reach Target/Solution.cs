// Minimum Queen Moves to Reach Target
namespace CompetitiveProgramming.LeetCode.MinimumQueenMovestoReachTarget;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinQueenMoves(int[] source, int[] target) => 
        source[0] == target[0] && source[1] == target[1] ? 0 : source[0] == target[0] || source[1] == target[1] ||
            Math.Abs(source[0] - target[0]) == Math.Abs(source[1] - target[1]) ? 1 : 2;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinQueenMoves([8,1], [1,8]), 1),
            ResultTester.CheckResult<int>(solution.MinQueenMoves([4,2], [1,3]), 2),
            ResultTester.CheckResult<int>(solution.MinQueenMoves([1,1], [1,1]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Queen Moves to Reach Target");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}