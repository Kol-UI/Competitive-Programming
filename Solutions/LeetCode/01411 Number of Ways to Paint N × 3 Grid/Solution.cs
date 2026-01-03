// Number of Ways to Paint N × 3 Grid
namespace CompetitiveProgramming.LeetCode.NumberofWaystoPaintNGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumOfWays(int n)
    {
        const int MOD = 1_000_000_007;

        long patternA = 6;
        long patternB = 6;

        for (int i = 2; i <= n; i++)
        {
            long newA = (patternA * 2 + patternB * 2) % MOD;
            long newB = (patternA * 2 + patternB * 3) % MOD;

            patternA = newA;
            patternB = newB;
        }

        return (int)((patternA + patternB) % MOD);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumOfWays(1), 12),
            ResultTester.CheckResult<int>(solution.NumOfWays(5000), 30228214)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Ways to Paint N x 3 Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}