// Path with Maximum Gold

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PathwithMaximumGold
{
    public class Solution
    {
        public static int GetMaximumGold(int[][] grid)
        {
            int maxGold = 0;
            
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        maxGold = Math.Max(maxGold, DFS(grid, i, j));
                    }
                }
            }
            
            return maxGold;
        }

        private static int DFS(int[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0)
            {
                return 0;
            }
            
            int currentGold = grid[i][j];
            grid[i][j] = 0;
            
            int maxGold = 0;
            
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i + 1, j));
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i - 1, j));
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i, j + 1));
            maxGold = Math.Max(maxGold, currentGold + DFS(grid, i, j - 1));
            
            grid[i][j] = currentGold;
            
            return maxGold;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Path with Maximum Gold");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}