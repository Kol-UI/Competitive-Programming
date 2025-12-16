// Maximum Profit from Trading Stocks with Discounts
namespace CompetitiveProgramming.LeetCode.MaximumProfitfromTradingStockswithDiscounts;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxProfit(int n, int[] costNow, int[] costLater, int[][] tree, int limit)
    {
        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++) adj[i] = new List<int>();
        foreach (var edge in tree) adj[edge[0] - 1].Add(edge[1] - 1);

        (int[] first, int[] second, int total) Visit(int node)
        {
            int price = costNow[node];
            int halfPrice = price / 2;

            int[] arr1 = new int[limit + 1];
            int[] arr2 = new int[limit + 1];
            int[] temp1 = new int[limit + 1];
            int[] temp2 = new int[limit + 1];
            int weight = price;

            foreach (int child in adj[node])
            {
                var (childArr1, childArr2, childWeight) = Visit(child);
                weight += childWeight;
                for (int i = limit; i >= 0; i--)
                {
                    for (int j = 0; j <= Math.Min(childWeight, i); j++)
                    {
                        if (i - j >= 0)
                        {
                            temp1[i] = Math.Max(temp1[i], temp1[i - j] + childArr1[j]);
                            temp2[i] = Math.Max(temp2[i], temp2[i - j] + childArr2[j]);
                        }
                    }
                }
            }

            for (int i = 0; i <= limit; i++)
            {
                arr1[i] = temp1[i];
                arr2[i] = temp1[i];
                if (i >= halfPrice)
                {
                    arr2[i] = Math.Max(temp1[i], temp2[i - halfPrice] + costLater[node] - halfPrice);
                }
                if (i >= price)
                {
                    arr1[i] = Math.Max(temp1[i], temp2[i - price] + costLater[node] - price);
                }
            }

            return (arr1, arr2, weight);
        }

        return Visit(0).first[limit];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Profit from Trading Stocks with Discounts");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}