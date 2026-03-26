// Climbing Stairs II
namespace CompetitiveProgramming.LeetCode.ClimbingStairsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ClimbStairs(int n, int[] costs)
    {
        if (costs.Length == 1) return costs[0] + 1;
        var aux = new int[costs.Length];
        for (int i = aux.Length - 2; i >= 0; i--)
        {
            var c = costs[i + 1] + 1 * 1 + aux[i + 1];
            if (i + 2 < aux.Length)
            {
                c = Math.Min(c, costs[i + 2] + 2 * 2 + aux[i + 2]);
            }
            if (i + 3 < aux.Length)
            {
                c = Math.Min(c, costs[i + 3] + 3 * 3 + aux[i + 3]);
            }
            aux[i] = c;
        }
        var result = costs[0] + 1 * 1 + aux[0];
        if (1 < aux.Length)
        {
            result = Math.Min(result, costs[1] + 2 * 2 + aux[1]);
        }
        if (2 < aux.Length)
        {
            result = Math.Min(result, costs[2] + 3 * 3 + aux[2]);
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
            ResultTester.CheckResult<int>(solution.ClimbStairs(4, [1,2,3,4]), 13),
            ResultTester.CheckResult<int>(solution.ClimbStairs(4, [5,1,6,2]), 11),
            ResultTester.CheckResult<int>(solution.ClimbStairs(3, [9,8,3]), 12),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Climbing Stairs II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}