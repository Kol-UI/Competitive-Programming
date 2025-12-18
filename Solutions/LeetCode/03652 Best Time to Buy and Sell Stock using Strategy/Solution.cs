// Best Time to Buy and Sell Stock using Strategy
namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockusingStrategy;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxProfit(int[] costs, int[] actions, int window)
    {
        int length = costs.Length;
        long best = long.MinValue;
        long currentSum = 0;
        long[] prefix = new long[length + 1];

        for (int i = 0; i < length; i++)
        {
            prefix[i + 1] = prefix[i] + costs[i] * actions[i];
        }

        best = prefix[length];
        int half = window / 2;

        for (int i = half; i < length; i++)
        {
            currentSum += costs[i];
            if (i >= window - 1)
            {
                if (i >= window) currentSum -= costs[i - half];
                int left = i - window + 1;
                int right = i;
                long leftPart = left > 0 ? prefix[left] : 0;
                long rightPart = prefix[length] - prefix[right + 1];
                best = Math.Max(best, leftPart + rightPart + currentSum);
            }
        }

        return best;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.MaxProfit([4,2,8], [-1,0,1], 2), 10),
            ResultTester.CheckResult<long>(solution.MaxProfit([5,4,3], [1,1,0], 2), 9),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Best Time to Buy and Sell Stock using Strategy");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}