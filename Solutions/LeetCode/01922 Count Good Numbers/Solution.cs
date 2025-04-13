// Count Good Numbers
namespace CompetitiveProgramming.LeetCode.CountGoodNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private const int MOD = 1_000_000_007;

    public int CountGoodNumbers(long n)
    {
        long evenCount = (n + 1) / 2;
        long oddCount = n / 2;

        long evenWays = ModPow(5, evenCount, MOD);
        long oddWays = ModPow(4, oddCount, MOD);

        return (int)((evenWays * oddWays) % MOD);
    }

    private long ModPow(long baseVal, long exp, int mod)
    {
        long result = 1;
        baseVal %= mod;

        while (exp > 0)
        {
            if ((exp & 1) == 1)
            {
                result = (result * baseVal) % mod;
            }
            baseVal = (baseVal * baseVal) % mod;
            exp >>= 1;
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountGoodNumbers(1), 5),
            ResultTester.CheckResult<int>(solution.CountGoodNumbers(4), 400),
            ResultTester.CheckResult<int>(solution.CountGoodNumbers(50), 564908303),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Good Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}