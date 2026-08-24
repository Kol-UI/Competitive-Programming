// Stone Game VIII
namespace CompetitiveProgramming.LeetCode.StoneGameVIII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int StoneGameVIII(int[] stones)
    {
        int n = stones.Length;
        long[] dp = new long[n];
        long[] prefixSums = new long[n];
        prefixSums[0] = stones[0];
        
        for(int i = 1; i < n; i++)
        {
            prefixSums[i] = stones[i] + prefixSums[i - 1];
        }
        
        dp[n-1] = prefixSums[n-1];

        for(int i = n - 2; i >= 0; i--)
        {
            dp[i] = Math.Max(dp[i + 1], prefixSums[i] - dp[i + 1]);
        }
        
        return (int)dp[1];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.StoneGameVIII([-1,2,-3,4,-5]), 5),
            ResultTester.CheckResult<int>(solution.StoneGameVIII([7,-6,5,10,5,-2,-6]), 13),
            ResultTester.CheckResult<int>(solution.StoneGameVIII([-10,-12]), -22)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stone Game VIII");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}