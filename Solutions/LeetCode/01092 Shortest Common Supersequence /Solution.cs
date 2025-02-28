// Shortest Common Supersequence 
namespace CompetitiveProgramming.LeetCode.ShortestCommonSupersequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string ShortestCommonSupersequence(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 1; i <= m; ++i)
        {
            for (int j = 1; j <= n; ++j)
            {
                if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else 
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        var sequence = new List<char>();
        int x = m, y = n;
        while (x > 0 || y > 0)
        {
            if (x == 0)
            {
                sequence.Add(str2[--y]);
            }
            else if (y == 0)
            {
                sequence.Add(str1[--x]);
            }
            else
            {
                if (dp[x, y] == dp[x - 1, y])
                {
                    sequence.Add(str1[--x]);
                }
                else if (dp[x, y] == dp[x, y - 1])
                {
                    sequence.Add(str2[--y]);
                }
                else
                {
                    sequence.Add(str1[--x]);
                    y--;
                }
            }
        }

        sequence.Reverse();

        return new string(sequence.ToArray());
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest Common Supersequence");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}