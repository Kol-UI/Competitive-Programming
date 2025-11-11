// Ones and Zeroes
namespace CompetitiveProgramming.LeetCode.OnesandZeroes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        int[][] dp = new int[m + 1][];
		
		for(int i = 0; i <= m; i++)
		{
			dp[i] = new int[n + 1];
		}
		
		foreach(string str in strs)
		{
			int zero = 0, one = 0;
			foreach (char c in str)
			{
			    if (c == '0')
					zero++;
			    else
					one++;
			}
			
			for(int i = m; i >= zero; i--)
			{
				for(int j = n; j >= one; j--)
				{
					dp[i][j] = Math.Max(dp[i][j], dp[i - zero][j - one] + 1);
				}
			}
		}
		
		return dp[m][n];
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ones and Zeroes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}