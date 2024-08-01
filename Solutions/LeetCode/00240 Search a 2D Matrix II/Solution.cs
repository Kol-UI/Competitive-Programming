// Search a 2D Matrix II

/*
Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. This matrix has the following properties:

Integers in each row are sorted in ascending from left to right.
Integers in each column are sorted in ascending from top to bottom.
 

Example 1:


Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 5
Output: true


Example 2:


Input: matrix = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]], target = 20
Output: false

*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Searcha2DMatrixII
{
    public class Solution
    {
        public static bool SearchMatrix(int[][] matrix, int target) 
        {
            int rows = matrix.Length;
            int column = matrix[0].Length;
            int i = 0;
            int j = column - 1;
            
            while(i < rows && j >= 0)
            {
                if(matrix[i][j] == target)
                    return true;
                
                if(matrix[i][j]>target)
                    j--;
                else
                    i++;
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix = new int[][]
            {
                new int[] {1, 4, 7, 11, 15},
                new int[] {2, 5, 8, 12, 19},
                new int[] {3, 6, 9, 16, 22},
                new int[] {10, 13, 14, 17, 24},
                new int[] {18, 21, 23, 26, 30}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.SearchMatrix(matrix, 5), true),
                ResultTester.CheckResult<bool>(Solution.SearchMatrix(matrix, 20), false),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search a 2D Matrix II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}