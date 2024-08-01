using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Searcha2DMatrix
{
	public class Solution
	{
        //You are given an m x n integer matrix matrix with the following two properties:

        //Each row is sorted in non-decreasing order.
        //The first integer of each row is greater than the last integer of the previous row.
        //Given an integer target, return true if target is in matrix or false otherwise.

        //You must write a solution in O(log(m* n)) time complexity.


        //Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
        //Output: true
        //Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
        //Output: false

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0)
            {
                return false;
            }

            int rows = matrix.Length;
            int columns = matrix[0].Length;
            int left = 0;
            int right = rows * columns - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int middlePoint = matrix[middle / columns][middle % columns];

                if (target == middlePoint)
                {
                    return true;
                }
                else if (target < middlePoint)
                {
                    right = middle - 1;
                }
                else if (target > middlePoint)
                {
                    left = middle + 1;
                }
            }

            return false;
        }
    }

    public class Test
    {
        public static bool[] TestSearcha2DMatrix()
        {
            int[][] Matrix74 = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
            };

            // Case 1
            int Case1_74_Target = 3;
            bool Case1_74_Result = Solution.SearchMatrix(Matrix74, Case1_74_Target);

            // Case 2
            int Case2_74_Target = 13;
            bool Case2_74_Result = Solution.SearchMatrix(Matrix74, Case2_74_Target);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Case1_74_Result, true),
                ResultTester.CheckResult<bool>(Case2_74_Result, false),
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
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSearcha2DMatrix());
        }
    }
}