// Find the Maximum Number of Fruits Collected
namespace CompetitiveProgramming.LeetCode.FindtheMaximumNumberofFruitsCollected;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxCollectedFruits(int[][] fruits)
    {
        int n = fruits.Length;
        int ans = 0;
        for(int i=0; i<n; i++) ans += fruits[i][i];

        int dp(int[][] f)
        {
            int[] prev = new int[n];
            Array.Fill(prev, int.MinValue);
            int[] curr = new int[n];
            prev[n-1] = f[0][n-1];
            
            for(int i=1; i<n-1; i++)
            {
                Array.Fill(curr, int.MinValue);
                for(int j=Math.Max(n-1-i, i+1); j<n; j++)
                {
                    int best = prev[j];
                    if(j-1 >= 0) best = Math.Max(best, prev[j-1]);
                    if(j+1 < n) best = Math.Max(best, prev[j+1]);
                    curr[j] = best + f[i][j];
                }
                (prev, curr) = (curr, prev);
            }
            return prev[n-1];
        }

        ans += dp(fruits);
        
        int[][] transposed = new int[n][];
        for(int i=0; i<n; i++)
        {
            transposed[i] = new int[n];
            for(int j=0; j<n; j++)
            {
                transposed[i][j] = fruits[j][i];
            }
        }

        ans += dp(transposed);
        return ans;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Maximum Number of Fruits Collected");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}