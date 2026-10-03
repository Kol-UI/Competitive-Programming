// Best Time to Buy and Sell Stock III
namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockIII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int n = prices.Length;
        int[][] next = new int[2][];
        next[0] = new int[3];
        next[1] = new int[3];

        for (int i = n - 1; i >= 0; i--)
        {
            int[][] curr = new int[2][];
            curr[0] = new int[3];
            curr[1] = new int[3];

            for (int j = 0; j < 2; j++)
            {
                for (int k = 1; k < 3; k++)
                {
                    if (j == 1)
                        curr[j][k] = Math.Max(-prices[i] + next[0][k], next[1][k]);
                    else
                        curr[j][k] = Math.Max(prices[i] + next[1][k - 1], next[0][k]);
                }
            }
            
            next = curr;
        }

        return next[1][2];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxProfit([3,3,5,0,0,3,1,4]), 6),
            ResultTester.CheckResult<int>(solution.MaxProfit([1,2,3,4,5]), 4),
            ResultTester.CheckResult<int>(solution.MaxProfit([7,6,4,3,1]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Best Time to Buy and Sell Stock III");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}