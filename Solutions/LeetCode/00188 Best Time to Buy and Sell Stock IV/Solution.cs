// Best Time to Buy and Sell Stock IV
namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockIV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxProfit(int k, int[] prices)
    {
        Dictionary<(int, bool, int), int> memo = [];

        int DP(int day, bool holding, int remaining)
        {
            if (day == prices.Length || remaining == 0) return 0;

            if (memo.TryGetValue((day, holding, remaining), out var value)) return value;

            int result = DP(day + 1, holding, remaining);

            if (holding)
            {
                result = Math.Max(result, prices[day] + DP(day + 1, false, remaining - 1));
            }
            else
            {
                result = Math.Max(result, -prices[day] + DP(day + 1, true, remaining));
            }

            memo[(day, holding, remaining)] = result;
            return result;
        }

        return DP(0, false, k);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxProfit(2, [2,4,1]), 2),
            ResultTester.CheckResult<int>(solution.MaxProfit(2, [3,2,6,5,0,3]), 7),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Best Time to Buy and Sell Stock IV");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}