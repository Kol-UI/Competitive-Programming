// Minimum Total Price After Applying Discounts
namespace CompetitiveProgramming.LeetCode.MinimumTotalPriceAfterApplyingDiscounts;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public double MinPrice(int[] prices, int[] discounts)
    {
        Array.Sort(prices, (a, b) => b.CompareTo(a));
        Array.Sort(discounts, (a, b) => b.CompareTo(a));
        int length = Math.Min(prices.Length, discounts.Length);
        double total = 0.0;
        for (int i = 0; i < length; i++)
        {
            total += prices[i] * (100.0 - discounts[i]) / 100.0;
        }
        if (prices.Length > discounts.Length)
        {
            total += prices.Skip(discounts.Length).Select(x => (double)x).Sum();
        }
        return total;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<double>(solution.MinPrice([10,30,21], [50,60]), 32.50000),
            ResultTester.CheckResult<double>(solution.MinPrice([100,70], [10,40,50]), 92.00000),
            ResultTester.CheckResult<double>(solution.MinPrice([7,3,9], [100,100]), 3.00000),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Total Price After Applying Discounts");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}