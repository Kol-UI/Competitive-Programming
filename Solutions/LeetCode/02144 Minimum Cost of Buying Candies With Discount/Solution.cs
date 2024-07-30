// Minimum Cost of Buying Candies With Discount

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumCostofBuyingCandiesWithDiscount
{
    public class Solution
    {
        public int MinimumCost(int[] cost) =>
            cost.OrderDescending().Where((c, i) => ++i % 3 != 0).Sum();
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost of Buying Candies With Discount");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}