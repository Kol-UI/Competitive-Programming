// Cyclically Shift Rows and Columns
namespace CompetitiveProgramming.LeetCode.CyclicallyShiftRowsandColumns;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[][] CyclicShift(int n, int[][] grid, int[] rowShift, int[] colShift)
    {
        var result = new int[n][];

        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        for(var i = 0; i < n; i++)
        {
            for(var j = 0; j < n; j++)
            {
                int newCol = (j - rowShift[i] + n) % n;
                int newRow = (i - colShift[newCol] + n) % n;
                result[newRow][newCol] = grid[i][j];
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[][]>(solution.CyclicShift(2, [[1,2],[3,4]], [1,0], [0,1]), [[2,4],[3,1]]),
            ResultTester.CheckResult<int[][]>(solution.CyclicShift(3, [[1,2,3],[4,5,6],[7,8,9]], [1,2,0], [2,2,1]), [[7,8,5],[2,3,9],[6,4,1]]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cyclically Shift Rows and Columns");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}