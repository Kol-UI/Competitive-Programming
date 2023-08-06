// Forming a Magic Square

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.FormingaMagicSquare
{
    class Result
    {

        /*
        * Complete the 'formingMagicSquare' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts 2D_INTEGER_ARRAY s as parameter.
        */

        public static int FormingMagicSquare(List<List<int>> s)
        {
            int[][] magicSquares = new int[][]
            {
                new int[] {8, 1, 6, 3, 5, 7, 4, 9, 2},
                new int[] {6, 1, 8, 7, 5, 3, 2, 9, 4},
                new int[] {4, 9, 2, 3, 5, 7, 8, 1, 6},
                new int[] {2, 9, 4, 7, 5, 3, 6, 1, 8},
                new int[] {8, 3, 4, 1, 5, 9, 6, 7, 2},
                new int[] {4, 3, 8, 9, 5, 1, 2, 7, 6},
                new int[] {6, 7, 2, 1, 5, 9, 8, 3, 4},
                new int[] {2, 7, 6, 9, 5, 1, 4, 3, 8}
            };

            int minCost = int.MaxValue;

            for (int i = 0; i < magicSquares.Length; i++)
            {
                int cost = 0;
                for (int j = 0; j < 9; j++)
                {
                    cost += Math.Abs(magicSquares[i][j] - s[j / 3][j % 3]);
                }
                minCost = Math.Min(minCost, cost);
            }

            return minCost;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            List<List<int>> test1 = new()
            {
                new List<int> {4, 9, 2},
                new List<int> {3, 5, 7},
                new List<int> {8, 1, 5}
            };
            // Expected output: 1

            List<List<int>> test2 = new()
            {
                new List<int> {4, 8, 2},
                new List<int> {4, 5, 7},
                new List<int> {6, 1, 6}
            };
            // Expected output: 4

            List<List<int>> test3 = new()
            {
                new List<int> {5, 3, 4},
                new List<int> {1, 5, 8},
                new List<int> {6, 4, 2}
            };
            // Expected output: 3

            List<List<int>> test4 = new()
            {
                new List<int> {1, 2, 3},
                new List<int> {4, 5, 6},
                new List<int> {7, 8, 9}
            };
            // Expected output: 14

            List<List<int>> test5 = new()
            {
                new List<int> {2, 9, 4},
                new List<int> {7, 5, 3},
                new List<int> {6, 1, 8}
            };
            // Expected output: 21

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Result.FormingMagicSquare(test1), 1),
                ResultTester.CheckResult<int>(Result.FormingMagicSquare(test2), 4),
                ResultTester.CheckResult<int>(Result.FormingMagicSquare(test3), 7),
                ResultTester.CheckResult<int>(Result.FormingMagicSquare(test4), 24),
                ResultTester.CheckResult<int>(Result.FormingMagicSquare(test5), 0),
            };
            return results;
        }
    }
}