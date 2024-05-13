// Score After Flipping Matrix


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ScoreAfterFlippingMatrix
{
    public class Solution
    {
        public static int MatrixScore(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length, half = (rows>>1), result = 0;

            for(int i = 0; i < rows; i++)
            {
                if(grid[i][0] == 1) continue;

                for(int j = 0; j < cols; j++)
                {
                    grid[i][j] ^= 1;
                }
            }

            for(int j = 0; j < cols; j++)
            {
                int count = 0;

                for(int i = 0; i < rows; i++)
                {
                    if(grid[i][j] == 1) count++;
                }

                if(count > half) continue;

                for(int i = 0; i < rows; i++)
                {
                    grid[i][j] ^= 1;
                }
            }

            for(int i = 0; i < rows; i++)
            {
                int temp = 0;

                for(int j = 0; j < cols; j++)
                {
                    temp = temp * 2 + grid[i][j];
                }

                result += temp;
            }

            return result;
        }
    }
}