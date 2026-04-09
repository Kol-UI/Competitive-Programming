// XOR After Range Multiplication Queries I
namespace CompetitiveProgramming.LeetCode.XORAfterRangeMultiplicationQueriesI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    int mod = 1000000007;

    public int XorAfterQueries(int[] nums, int[][] queries)
    {
        int n = nums.Length;
        foreach (var q in queries)
        {
            int l = q[0], r = q[1], k = q[2], v = q[3];
            for (int i = l; i <= r; i += k)
                nums[i] = (int)((long)nums[i] * v % mod);
        }

        int res = 0;
        foreach (int x in nums)
            res ^= x;
        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.XorAfterQueries([1,1,1], [[0,2,1,4]]), 4),
            ResultTester.CheckResult<int>(solution.XorAfterQueries([2,3,1,5,4], [[1,4,2,3],[0,2,1,2]]), 31),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("XOR After Range Multiplication Queries I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}