// Minimum Changes to Make K Semi-palindromes
namespace CompetitiveProgramming.LeetCode.MinimumChangestoMakeKSemipalindromes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int GetMinChanges(string s, int l, int r)
    {
        int len = r - l + 1;
        if (len == 1) return 0;

        int minChanges = int.MaxValue;

        for (int i = 1; i <= len / 2; i++)
        {
            if (len % i != 0) continue;

            int currentChanges = 0;
            for (int j = 0; j < i; j++)
            {
                int left = j, right = len - i + j;
                while (left < right)
                {
                    if (s[left + l] != s[right + l]) currentChanges++;
                    left += i;
                    right -= i;
                }
            }

            minChanges = Math.Min(minChanges, currentChanges);
        }

        return minChanges;
    }

    private int CalculateMinChangesWithKPartitions(string s, int pos, int k, int[][] minChangesMatrix, int[][] dp)
    {
        int n = s.Length;

        if (pos >= n || n - pos < 2 * (k + 1)) return -1;
        if (k == 0) return minChangesMatrix[pos][n - 1];
        if (dp[pos][k] != -1) return dp[pos][k];

        int minChanges = int.MaxValue;

        for (int i = pos + 1; i < n; i++)
        {
            int temp = CalculateMinChangesWithKPartitions(s, i + 1, k - 1, minChangesMatrix, dp);
            if (temp >= 0) minChanges = Math.Min(minChanges, temp + minChangesMatrix[pos][i]);
        }

        dp[pos][k] = (minChanges == int.MaxValue) ? -2 : minChanges;
        return dp[pos][k];
    }

    public int MinimumChanges(string s, int k)
    {
        int n = s.Length;
        int[][] minChangesMatrix = new int[n][];
        int[][] dp = new int[n + 1][];
        for (int i = 0; i < n; i++) minChangesMatrix[i] = new int[n];
        for (int i = 0; i <= n; i++) dp[i] = new int[k + 1];
        foreach (var row in dp) Array.Fill(row, -1);

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                minChangesMatrix[i][j] = minChangesMatrix[j][i] = GetMinChanges(s, i, j);
            }
        }

        return CalculateMinChangesWithKPartitions(s, 0, k - 1, minChangesMatrix, dp);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumChanges("abcac", 2), 1),
            ResultTester.CheckResult<int>(solution.MinimumChanges("abcdef", 2), 2),
            ResultTester.CheckResult<int>(solution.MinimumChanges("aabbaa", 3), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Changes to Make K Semi-palindromes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}