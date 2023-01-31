using System;
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
}

