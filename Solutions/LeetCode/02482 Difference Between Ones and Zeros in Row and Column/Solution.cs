// Difference Between Ones and Zeros in Row and Column



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DifferenceBetweenOnesandZerosinRowandColumn
{
    public class Solution
    {
        public static int[][] OnesMinusZeros(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            int[][] diff = new int[n][];
            int[] onesRow = new int[n];
            int[] onesCol = new int[m];

            for (int i = 0; i < n; i++)
            {
                diff[i] = new int[m];
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    if (grid[r][c] == 1)
                    {
                        onesRow[r]++;
                        onesCol[c]++;
                    }
                }
            }
            
            for (int r = 0; r < n; r++)
            {
                int zeroRow = m - onesRow[r];
                
                for (int c = 0; c < m; c++)
                {
                    int zeroCol = n - onesCol[c];
                    diff[r][c] = onesRow[r] + onesCol[c] - zeroRow - zeroCol;
                }
            }
            
            return diff;
        }


        public static int[][] OnesMinusZeros2(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            int[][] diff = new int[n][];
            int[] onesRow = new int[n];
            int[] onesCol = new int[m];

            for (int i = 0; i < n; i++)
            {
                diff[i] = new int[m];
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    if (grid[r][c] == 1)
                    {
                        onesRow[r]++;
                        onesCol[c]++;
                    }
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    int zeroRow = m - onesRow[r];
                    int zeroCol = n - onesCol[c];
                    diff[r][c] = onesRow[r] + onesCol[c] - zeroRow - zeroCol;
                }
            }

            return diff;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] grid1 = new int[][]
            {
                new int[] {0, 1, 1},
                new int[] {1, 0, 1},
                new int[] {0, 0, 1}
            };

            int[][] grid2 = new int[][]
            {
                new int[] {1, 1, 1},
                new int[] {1, 1, 1}
            };

            int[][] result1 = new int[][]
            {
                new int[] {0, 0, 4},
                new int[] {0, 0, 4},
                new int[] {-2, -2, 2}
            };

            int[][] result2 = new int[][]
            {
                new int[] {5, 5, 5},
                new int[] {5, 5, 5}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.OnesMinusZeros(grid1), result1),
                ResultTester.CheckResult<int[][]>(Solution.OnesMinusZeros(grid2), result2),
                ResultTester.CheckResult<int[][]>(Solution.OnesMinusZeros2(grid1), result1),
                ResultTester.CheckResult<int[][]>(Solution.OnesMinusZeros2(grid2), result2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Difference Between Ones and Zeros in Row and Column");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}