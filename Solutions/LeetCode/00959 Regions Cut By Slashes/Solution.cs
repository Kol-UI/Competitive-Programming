// Regions Cut By Slashes

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RegionsCutBySlashes
{
    public sealed class Solution
    {
        private const int Scale = 3;
        private const char RightSlash = '/';
        private const char LeftSlash = '\\';

        public int RegionsBySlashes(string[] grid)
        {
            int gridSize = grid.Length;
            int scaledSize = gridSize * Scale;
            int regionCount = 0;

            bool[,] scaledGrid = new bool[scaledSize, scaledSize];

            for (int i = 0; i < gridSize; i++)
            {
                int xOffset = i * Scale;
                for (int j = 0; j < gridSize; j++)
                {
                    int yOffset = j * Scale;
                    MarkGrid(grid[i][j], scaledGrid, xOffset, yOffset);
                }
            }

            for (int i = 0; i < scaledSize; i++)
            {
                for (int j = 0; j < scaledSize; j++)
                {
                    if (ExploreRegion(scaledGrid, i, j))
                    {
                        regionCount++;
                    }
                }
            }

            return regionCount;
        }

        private void MarkGrid(char symbol, bool[,] grid, int x, int y)
        {
            if (symbol == RightSlash)
            {
                grid[x, y + 2] = true;
                grid[x + 1, y + 1] = true;
                grid[x + 2, y] = true;
            }
            else if (symbol == LeftSlash)
            {
                grid[x, y] = true;
                grid[x + 1, y + 1] = true;
                grid[x + 2, y + 2] = true;
            }
        }

        private bool ExploreRegion(bool[,] grid, int x, int y)
        {
            int gridSize = grid.GetLength(0);
            
            if (x < 0 || y < 0 || x >= gridSize || y >= gridSize || grid[x, y])
            {
                return false;
            }

            grid[x, y] = true;

            ExploreRegion(grid, x - 1, y);
            ExploreRegion(grid, x + 1, y);
            ExploreRegion(grid, x, y - 1);
            ExploreRegion(grid, x, y + 1);

            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Regions Cut By Slashes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}