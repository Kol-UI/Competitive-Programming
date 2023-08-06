// Beautiful Matrix

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.BeautifulMatrix
{
    // Solution
    /*
    class Solution
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }

            int rowOfOne = -1;
            int colOfOne = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        rowOfOne = i;
                        colOfOne = j;
                        break;
                    }
                }
            }

            int moves = Math.Abs(rowOfOne - 2) + Math.Abs(colOfOne - 2);

            Console.WriteLine(moves);
        }
    }
    */


    // Test
    public class Test
    {
        public static int TestSolution(int[][] matrix)
        {
            /*
            int[][] matrix = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            */

            int rowOfOne = -1;
            int colOfOne = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        rowOfOne = i;
                        colOfOne = j;
                        break;
                    }
                }
            }

            int moves = Math.Abs(rowOfOne - 2) + Math.Abs(colOfOne - 2);

            return moves;
            //Console.WriteLine(moves);
        }

        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };

            int[][] matrix3 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 }
            };

            int[][] matrix4 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 1 }
            };

            int[][] matrix5 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 1, 0 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.TestSolution(matrix1), 3),
                ResultTester.CheckResult<int>(Test.TestSolution(matrix2), 1),
                ResultTester.CheckResult<int>(Test.TestSolution(matrix3), 0),
                ResultTester.CheckResult<int>(Test.TestSolution(matrix4), 4),
                ResultTester.CheckResult<int>(Test.TestSolution(matrix5), 3),
            };
            return results;
        }
    }
}