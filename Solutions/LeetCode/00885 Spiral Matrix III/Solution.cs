// Spiral Matrix III

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SpiralMatrixIII
{
    public class Solution 
    {
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) 
        {
            List<int[]> result = new List<int[]>();
            int[,] directions = new int[,] 
            { 
                { 0, 1 },  // right
                { 1, 0 },  // down
                { 0, -1 }, // left
                { -1, 0 }  // up
            };

            int len = 0;
            int direction = 0;

            result.Add(new int[] { rStart, cStart });

            while (result.Count < rows * cols) 
            {
                if (direction == 0 || direction == 2) 
                {
                    len++;
                }

                for (int i = 0; i < len; i++) 
                {
                    rStart += directions[direction, 0];
                    cStart += directions[direction, 1];

                    if (IsWithinBounds(rStart, cStart, rows, cols)) 
                    {
                        result.Add(new int[] { rStart, cStart });
                    }
                }

                direction = (direction + 1) % 4;
            }

            return result.ToArray();
        }

        private bool IsWithinBounds(int row, int col, int rows, int cols) 
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix III");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}