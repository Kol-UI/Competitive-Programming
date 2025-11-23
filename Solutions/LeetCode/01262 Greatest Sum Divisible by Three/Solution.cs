// Greatest Sum Divisible by Three
namespace CompetitiveProgramming.LeetCode.GreatestSumDivisiblebyThree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxSumDivThree(int[] nums)
    {
        int[] dp = new int[3];
        foreach(var num in nums)
        {
            var temp = dp.ToArray();
            foreach(var sum in temp)
            {
                int rem = (sum + num) % 3;
                dp[rem] = Math.Max(dp[rem], sum + num);
            }
        }

        return dp[0];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Greatest Sum Divisible by Three");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}