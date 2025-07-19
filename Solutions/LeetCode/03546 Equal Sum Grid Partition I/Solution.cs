// Equal Sum Grid Partition I
namespace CompetitiveProgramming.LeetCode.EqualSumGridPartitionI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public bool CanPartitionGrid(int[][] grid) 
    {
        int hor = grid.Length;
        int vert = grid[0].Length;

        long[] horsum = new long[hor];
        long[] vertsum = new long[vert];
        long total = 0;

        for (var i = 0; i < hor; i++)
        {
            for (var j = 0; j < vert; j++)
            {
                horsum[i] += grid[i][j];
                vertsum[j] += grid[i][j];
                total += grid[i][j];
            }
        }

        long h = 0, v = 0;

        for (var i = 0; i < hor; i++)
        {
            h += horsum[i];
            if (h == total - h)
                return true;
            if (h > total - h)
                break;
        }

        for (var j = 0; j < vert; j++)
        {
            v += vertsum[j];
            if (v == total - v)
                return true;
            if (v > total - v)
                return false;
        }

        return false;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Equal Sum Grid Partition I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}