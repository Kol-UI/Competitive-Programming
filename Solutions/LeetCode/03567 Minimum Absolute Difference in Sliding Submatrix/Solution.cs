// Minimum Absolute Difference in Sliding Submatrix
namespace CompetitiveProgramming.LeetCode.MinimumAbsoluteDifferenceinSlidingSubmatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution {
    public int[][] MinAbsDiff(int[][] grid, int k) {
        int n = grid.Length;
        int m = grid[0].Length;
        int [][] ans = new int [n-k+1][];
        for(int i=0;i<n-k+1;i++)
        {
            ans[i] = new int[m-k+1];
        }
        if(k == 1)
        {
            return ans;
        }
        for(int i=0;i<n-k+1;i++)
        {
            for(int j=0;j<m-k+1;j++)
            {
                int cmin = int.MaxValue;
                HashSet<int> hs = new HashSet<int>();
                for(int l1=i;l1<i+k;l1++)
                {
                    for(int m1=j;m1<j+k;m1++)
                    {
                        hs.Add(grid[l1][m1]);
                    }
                }
                List<int> lst = new List<int>(hs);
                lst.Sort();
                for(int l1 = 0;l1<lst.Count-1;l1++)
                {
                    cmin = Math.Min(cmin, Math.Abs(lst[l1] - lst[l1+1]));
                }
                ans[i][j] = Math.Min(cmin, Math.Abs(lst[0] - lst[lst.Count-1]));;
            }
        }
        return ans;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Absolute Difference in Sliding Submatrix");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}