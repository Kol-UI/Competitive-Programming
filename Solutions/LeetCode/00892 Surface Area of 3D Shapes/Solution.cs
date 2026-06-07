// Surface Area of 3D Shapes
namespace CompetitiveProgramming.LeetCode.SurfaceAreaof3DShapes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int SurfaceArea(int[][] grid) {
        int n = grid.Length;
        int surfaceArea = 0;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] != 0) {
                    surfaceArea += (4 * grid[i][j] + 2);

                    int[][] directions = {new int[] {1, 0}, new int[] {-1, 0}, new int[] {0, 1}, new int[] {0, -1}};
                    foreach (var dir in directions) {
                        int x = i + dir[0];
                        int y = j + dir[1];
                        if (x >= 0 && x < n && y >= 0 && y < n) {
                            surfaceArea -= Math.Min(grid[i][j], grid[x][y]);
                        }
                    }
                }
            }
        }

        return surfaceArea;
    }
}


public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SurfaceArea([[1,2],[3,4]]), 34),
            ResultTester.CheckResult<int>(solution.SurfaceArea([[1,1,1],[1,0,1],[1,1,1]]), 32),
            ResultTester.CheckResult<int>(solution.SurfaceArea([[2,2,2],[2,1,2],[2,2,2]]), 46),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Surface Area of 3D Shapes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}