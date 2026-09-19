// Number of Sets of K Non-Overlapping Line Segments
namespace CompetitiveProgramming.LeetCode.NumberofSetsofKNonOverlappingLineSegments;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfSets(int n, int k)
    {
        const int MOD = 1000000007;
        int[] dp = new int[n];
        int[] prefixSums = new int[n + 1];
        for (int j = 0; j < n; j++)
        {
            dp[j] = 1;
            prefixSums[j + 1] = (prefixSums[j] + dp[j]) % MOD;
        }
        for (int i = 1; i <= k; i++)
        {
            dp[0] = 0;
            for (int j = 1; j < n; j++)
                dp[j] = (dp[j - 1] + prefixSums[j]) % MOD;
            for (int j = 0; j < n; j++)
                prefixSums[j + 1] = (prefixSums[j] + dp[j]) % MOD;
        }
        return dp[n - 1];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumberOfSets(4, 2), 5),
            ResultTester.CheckResult<int>(solution.NumberOfSets(3, 1), 3),
            ResultTester.CheckResult<int>(solution.NumberOfSets(30, 7), 796297179),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Sets of K Non-Overlapping Line Segments");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}