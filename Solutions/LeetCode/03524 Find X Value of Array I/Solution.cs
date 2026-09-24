// Find X Value of Array I
namespace CompetitiveProgramming.LeetCode.FindXValueofArrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long[] ResultArray(int[] nums, int k)
    {
        int n = nums.Length;
        long[] result = new long[k];
        long[] dp = new long[k];

        for (int i = 0; i < n; i++)
        {
            long[] ndp = new long[k];
            ndp[nums[i] % k]++;

            for (int r = 0; r < k; r++)
            {
                ndp[(int)(((long)r * nums[i]) % k)] += dp[r];
            }

            dp = ndp;

            for (int r = 0; r < k; r++)
            {
                result[r] += dp[r];
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long[]>(solution.ResultArray([1,2,3,4,5], 3), [9,2,4]),
            ResultTester.CheckResult<long[]>(solution.ResultArray([1,2,4,8,16,32], 4), [18,1,2,0]),
            ResultTester.CheckResult<long[]>(solution.ResultArray([1,1,2,1,1], 2), [9,6]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find X Value of Array I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}