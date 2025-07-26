// Best Time to Buy and Sell Stock V
namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaximumProfit(int[] prices, int k)
    {
        int n = prices.Length;

        long [][][] dp = new long [k+1][][];
        for(int i=0;i<k+1;i++)
        {
            dp[i] = new long[n+1][];
            for(int j=0;j<n;j++)
            {
                dp[i][j] = new long [3];
            }
        }
        return MaxProf(prices, k,0, ref dp, 2);
    }

    public long MaxProf(int [] prices, int k, int i, ref long [][][] dp, int h)
    {
        if(k == 0 )
        {
            return 0;
        }
        if(i == prices.Length-1)
        {
            if(h == 2)
                return 0;
            if(h == 1)
            {
                return prices[i];
            }
            return -prices[i];
        }
        if(dp[k][i][h] != 0 )
        {
            return dp[k][i][h];
        }

        long noop = long.MinValue;
        long v1 = long.MinValue;

        noop = MaxProf(prices, k,i + 1, ref dp, h);

        if(h == 0)
        {
            v1 = Math.Max(MaxProf(prices, k-1,i+1, ref dp,2) - prices[i], noop);
        }
        else if(h == 1)
        {
            v1 = Math.Max(MaxProf(prices, k-1,i+1, ref dp,2) + prices[i], noop);
        }
        else
        {
            v1 = Math.Max(prices[i] + MaxProf(prices, k,i+1,ref dp, 0), noop);
            v1 = Math.Max(v1,MaxProf(prices, k,i+1,ref dp, 1) - prices[i]);
        }
        
        return dp[k][i][h] = Math.Max(v1,noop);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Best Time to Buy and Sell Stock V");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}