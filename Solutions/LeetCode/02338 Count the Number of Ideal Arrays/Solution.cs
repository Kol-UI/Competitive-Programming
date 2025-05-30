// Count the Number of Ideal Arrays
namespace CompetitiveProgramming.LeetCode.CounttheNumberofIdealArrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    long[,] dp = new long[15, 10001];
    long[,] pr = new long[15, 10001];
    long[] tot = new long[15];
    const long mod = 1000000007;
    int n, mx;

    void Get(int la, int cn){
        tot[cn]++;
        for(int p = 2 * la; p <= mx; p += la)
        Get(p, cn + 1);
    }

    public int IdealArrays(int nn, int mmx) {
        n = nn;
        mx = mmx;

        for (int i = 1; i <= 10000; i++){
            dp[1, i] = 1;
            pr[1, i] = i;
        }

        for(int i = 2; i < 15; i++){
            for(int j = 1; j <= 10000; j++){
                dp[i, j] = pr[i - 1, j - 1];
                pr[i, j] = (dp[i, j] + pr[i, j - 1]) % mod;
            }
        }

        for(int i = 1; i <= mx; i++)
        Get(i, 1);

        long ans = mx;
        for(int i = 2; i < 15; i++){
            ans = (ans + tot[i] * dp[i, n]) % mod;
        }

        return (int)ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.IdealArrays(2,5), 10),
            ResultTester.CheckResult<int>(solution.IdealArrays(5,3), 37),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count the Number of Ideal Arrays");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}