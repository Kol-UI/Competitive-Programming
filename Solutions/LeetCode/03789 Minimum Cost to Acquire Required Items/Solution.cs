// Minimum Cost to Acquire Required Items
namespace CompetitiveProgramming.LeetCode.MinimumCosttoAcquireRequiredItems;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2)
    {
        long totalCost = 0;

        if (cost1 + cost2 <= costBoth)
        {
            totalCost = 1L * cost1 * need1 + 1L * cost2 * need2;
        }
        else
        {
            int cnt_3 = Math.Min(need1, need2);
            totalCost = 1L * cnt_3 * costBoth;

            need1 -= cnt_3;
            need2 -= cnt_3;

            if (need1 > 0)
            {
                totalCost += 1L * need1 * Math.Min(cost1, costBoth);
            }
            else if (need2 > 0)
            {
                totalCost += 1L * need2 * Math.Min(cost2, costBoth);
            }
        }

        return totalCost;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MinimumCost(3, 2, 1, 3, 2), 3),
            ResultTester.CheckResult<long>(solution.MinimumCost(5, 4, 15, 2, 3), 22),
            ResultTester.CheckResult<long>(solution.MinimumCost(5, 4, 15, 0, 0), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Cost to Acquire Required Items");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}