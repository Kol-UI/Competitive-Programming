// Minimum Moves to Equal Array Elements
namespace CompetitiveProgramming.LeetCode.MinimumMovestoEqualArrayElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinMoves(int[] nums)
    {
        int minV = int.MaxValue, maxV = int.MaxValue, res = 0, sum = 0, n = nums.Length;

        foreach(int cur in nums)
        {
            minV = Math.Min(minV, cur);
            maxV = Math.Max(maxV, cur);
            sum += cur;
        }

        if(maxV == minV)
            return res;

        res = sum - n*minV;
        return res;
    }
}
public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinMoves([1,2,3]), 3),
            ResultTester.CheckResult<int>(solution.MinMoves([1,1,1]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Moves to Equal Array Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}