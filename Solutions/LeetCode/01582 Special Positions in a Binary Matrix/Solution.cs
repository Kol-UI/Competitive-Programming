// Special Positions in a Binary Matrix



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SpecialPositionsinaBinaryMatrix
{
    public class Solution
    {
        public static int NumSpecial(int[][] mat)
        {
            int x = mat.Length;
            int y = mat[0].Length;
            int[] Rows = new int[x];
            int[] Cols = new int[y];
            int Number = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Rows[i] += mat[i][j];
                    Cols[j] += mat[i][j];
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mat[i][j] == 1 && Rows[i] == 1 && Cols[j] == 1)
                    {
                        Number++;
                    }
                }
            }

            return Number;
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] mat1 = new int[][]
            {
                new int[] {1, 0, 0},
                new int[] {0, 0, 1},
                new int[] {1, 0, 0}
            };

            int[][] mat2 = new int[][]
            {
                new int[] {1, 0, 0},
                new int[] {0, 1, 0},
                new int[] {0, 0, 1}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumSpecial(mat1), 1),
                ResultTester.CheckResult<int>(Solution.NumSpecial(mat2), 3),
            };
            return results;
        }
    }
}