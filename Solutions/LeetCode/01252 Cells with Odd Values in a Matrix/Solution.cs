// Cells with Odd Values in a Matrix
namespace CompetitiveProgramming.LeetCode.CellswithOddValuesinaMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int OddCells(int m, int n, int[][] indices) 
    {
        int[,] v = new int[m,n];
        int count = 0;
        foreach(var pair in indices)
        {
            int r=pair[0];
            int c=pair[1];
            for(int j=0;j<n;j++)
            {
                v[r,j]++;
            }
            for(int i=0;i<m;i++)
            {
                v[i,c]++;
            }
        }
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(v[i,j]%2!=0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.OddCells(2, 3, [[0,1],[1,1]]), 6),
            ResultTester.CheckResult<int>(solution.OddCells(2, 2, [[1,1],[0,0]]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cells with Odd Values in a Matrix");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}