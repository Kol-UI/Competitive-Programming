// Minimum Cost to Reach Every Position
namespace CompetitiveProgramming.LeetCode.MinimumCosttoReachEveryPosition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MinCosts(int[] cost)
    {
        var min = cost[0];
        for(var i = 1; i < cost.Length; i++)
        {
            if(cost[i] >= min) cost[i] = min;
            else min = cost[i];
        }
        return cost;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Cost to Reach Every Position");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}