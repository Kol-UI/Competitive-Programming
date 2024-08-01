// Spiral Matrix

/*
Given an m x n matrix, return all elements of the matrix in spiral order.

 

Example 1:


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]

Example 2:


Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SpiralMatrix
{
    public class Solution
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            var width = matrix[0].Length;
            var height = matrix.Length;
            var lenght = width * height;

            var result = new List<int>(lenght);
            var x = 0;
            var y = 0;
            var dy = 1;
            var dx = 1;

            while(result.Count < lenght)
            {
                result.Add(matrix[y][x]);

                if (y == dy - 1 && x < width - dx)
                {
                    x++;
                }
                else if (x == width - dx && y < height - dy)
                {
                    y++;
                }
                else if (x > dx - 1)
                {
                    x--;
                }
                else if (y > dy)
                {
                    y--;
                    if (y == dy && x == dx - 1)
                    {
                        dx++;
                        dy++;
                    }
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSpiralMatrix()
        {
            // Example 1 - Input Matrix
            int[][] matrix1 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            // Example 1 - Output List
            IList<int> output1 = new List<int> {1, 2, 3, 6, 9, 8, 7, 4, 5};

            // Example 2 - Input Matrix
            int[][] matrix2 = new int[][]
            {
                new int[] {1, 2, 3, 4},
                new int[] {5, 6, 7, 8},
                new int[] {9, 10, 11, 12}
            };

            // Example 2 - Output List
            IList<int> output2 = new List<int> {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.SpiralOrder(matrix1), output1),
                ResultTester.CheckResult<IList<int>>(Solution.SpiralOrder(matrix2), output2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSpiralMatrix());
        }
    }
}