// Find a Peak Element II

/*
A peak element in a 2D grid is an element that is strictly greater than all of its adjacent neighbors to the left, right, top, and bottom.

Given a 0-indexed m x n matrix mat where no two adjacent cells are equal, find any peak element mat[i][j] and return the length 2 array [i,j].

You may assume that the entire matrix is surrounded by an outer perimeter with the value -1 in each cell.

You must write an algorithm that runs in O(m log(n)) or O(n log(m)) time.

 

Example 1:

Input: mat = [[1,4],[3,2]]
Output: [0,1]
Explanation: Both 3 and 4 are peak elements so [1,0] and [0,1] are both acceptable answers.

Example 2:

Input: mat = [[10,20,15],[21,30,14],[7,16,32]]
Output: [1,1]
Explanation: Both 30 and 32 are peak elements so [1,1] and [2,2] are both acceptable answers.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindaPeakElementII
{
    public class Solution
    {
        public static int[] FindPeakGrid(int[][] mat)
        {
            int begin = 0;
            int end = mat.Length - 1;  
            int col = 0; 

            while(begin < end)
            {
                int row = begin + (end-begin) / 2;       
                col = Array.IndexOf(mat[row], mat[row].Max());
                                
                if(mat[row][col] >  mat[row + 1][col])
                    end = row;
                else 
                    begin = row + 1;
            }
            return new int[] {end, col};
        }

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 3, 2 }
            };
            int[][] mat2 = new int[][]
            {
                new int[] { 10, 20, 15 },
                new int[] { 21, 30, 14 },
                new int[] { 7, 16, 32 }
            };

            int[] result1 = Solution.FindPeakGrid(mat1);
            int[] result2 = Solution.FindPeakGrid(mat2);
            int[] expected1 = {0,1};
            int[] expected2 = {1,1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find a Peak Element II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}