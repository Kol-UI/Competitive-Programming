// Check if Matrix Is X-Matrix
namespace CompetitiveProgramming.LeetCode.CheckifMatrixIsXMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckXMatrix(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (i == j || i + j == grid.Length - 1)
                {
                    if (grid[i][j] == 0) return false;
                }
                else
                {
                    if (grid[i][j] != 0)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CheckXMatrix([[2,0,0,1],[0,3,1,0],[0,5,2,0],[4,0,0,2]]), true),
            ResultTester.CheckResult<bool>(solution.CheckXMatrix([[5,7,0],[0,3,1],[0,5,0]]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Matrix Is X-Matrix");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}