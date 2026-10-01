// Projection Area of 3D Shapes
namespace CompetitiveProgramming.LeetCode.ProjectionAreaofThreeDShapes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ProjectionArea(int[][] grid)
    {
        int topProjection = 0, rowProjection = 0, colProjection = 0;
        int[] maxNumberInCols = new int[grid.Length];
        for(int i = 0; i < grid.Length;i++)
        {
            int maxNumberInRow = grid[i][0];
            for(int j = 0; j < grid.Length;j++)
            {
                if(grid[i][j] > 0) topProjection++;
                maxNumberInRow = Math.Max(maxNumberInRow,grid[i][j]);
                maxNumberInCols[j] = Math.Max(maxNumberInCols[j],grid[i][j]);
            }
            rowProjection+= maxNumberInRow;
        }
        for(int i = 0;i < maxNumberInCols.Length;i++) colProjection += maxNumberInCols[i];
        return topProjection + rowProjection  + colProjection;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ProjectionArea([[1,2],[3,4]]), 17),
            ResultTester.CheckResult<int>(solution.ProjectionArea([[2]]), 5),
            ResultTester.CheckResult<int>(solution.ProjectionArea([[1,0],[0,2]]), 8),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Projection Area of 3D Shapes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}