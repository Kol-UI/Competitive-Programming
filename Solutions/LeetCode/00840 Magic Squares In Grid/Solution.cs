// Magic Squares In Grid

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MagicSquaresInGrid
{
    public class Solution 
    {
        public int NumMagicSquaresInside(int[][] grid) 
        {
            int magicSquareCount = 0;

            for (int i = 1; i < grid.Length - 1; i++) 
            {
                for (int j = 1; j < grid[i].Length - 1; j++) 
                {
                    if (IsMagicSquare(i, j, grid)) 
                    {
                        magicSquareCount++;
                    }
                }    
            }

            return magicSquareCount;
        }

        private bool IsMagicSquare(int row, int col, int[][] grid) 
        {
            if (grid[row][col] != 5) 
            {
                return false;
            }

            HashSet<int> uniqueNumbers = new HashSet<int>();

            for (int i = row - 1; i <= row + 1; i++) 
            {
                int rowSum = 0;

                for (int j = col - 1; j <= col + 1; j++) 
                {
                    if (grid[i][j] < 1 || grid[i][j] > 9) 
                    {
                        return false;
                    }

                    uniqueNumbers.Add(grid[i][j]);
                    rowSum += grid[i][j];
                }

                if (rowSum != 15) 
                {
                    return false;
                }
            }

            if (uniqueNumbers.Count != 9) 
            {
                return false;
            }

            for (int j = col - 1; j <= col + 1; j++) 
            {
                int colSum = 0;

                for (int i = row - 1; i <= row + 1; i++) 
                {
                    colSum += grid[i][j];
                }

                if (colSum != 15) 
                {
                    return false;
                }
            }

            if (grid[row - 1][col - 1] + grid[row][col] + grid[row + 1][col + 1] != 15) 
            {
                return false;
            }

            if (grid[row - 1][col + 1] + grid[row][col] + grid[row + 1][col - 1] != 15) 
            {
                return false;
            }

            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Magic Squares In Grid");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}