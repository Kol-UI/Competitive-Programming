// Delete Columns to Make Sorted III
namespace CompetitiveProgramming.LeetCode.DeleteColumnstoMakeSortedIII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int n = strs.Length;
        int m = strs[0].Length;

        int[] dp = Enumerable.Repeat(1, m).ToArray();
        int res = 1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k <= n; k++)
                {
                    if (k == n)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                        res = Math.Max(res, dp[i]);
                    }
                    else if (strs[k][j] > strs[k][i])
                    {
                        break;
                    }
                }
            }
        }
        return m - res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinDeletionSize(["babca","bbazb"]), 3),
            ResultTester.CheckResult<int>(solution.MinDeletionSize(["edcba"]), 4),
            ResultTester.CheckResult<int>(solution.MinDeletionSize(["ghi","def","abc"]), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Delete Columns to Make Sorted III");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}