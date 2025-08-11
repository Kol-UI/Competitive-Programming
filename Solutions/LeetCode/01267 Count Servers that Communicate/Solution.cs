// Count Servers that Communicate

namespace CompetitiveProgramming.LeetCode.CountServersthatCommunicate;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountServers(int[][] grid)
    {
        int n = grid.Length, m = grid[0].Length;

        int[] rows = new int[n];
        int[] cols = new int[m];
        for(int i = 0;i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(grid[i][j] == 1)
                {
                    rows[i]++;
                    cols[j]++;
                }
            }
        }

        int cnt = 0;

        for(int i = 0;i < n; i++)
        {
            for(int j = 0;j < m; j++)
            {
                if(grid[i][j] == 1 && (rows[i] > 1 || cols[j] > 1 ))
                {
                    cnt++;
                }
            }
        }
        return cnt;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Servers that Communicate");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}