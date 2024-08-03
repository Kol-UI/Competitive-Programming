//  Maximum Side Length of a Square with Sum Less than or Equal to Threshold

/*
Given a m x n matrix mat and an integer threshold, return the maximum side-length of a square with a sum less than or equal to threshold or return 0 if there is no such square.

 

Example 1:


Input: mat = [[1,1,3,2,4,3,2],[1,1,3,2,4,3,2],[1,1,3,2,4,3,2]], threshold = 4
Output: 2
Explanation: The maximum side length of square with sum less than 4 is 2 as shown.


Example 2:

Input: mat = [[2,2,2,2,2],[2,2,2,2,2],[2,2,2,2,2],[2,2,2,2,2],[2,2,2,2,2]], threshold = 1
Output: 0
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold
{
    public class Solution
    {
        public static int MaxSideLength(int[][] mat, int threshold)
        {
            int maxSideLength = 0;
            int rows = mat.Length;
            int columns = mat[0].Length;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    int sum = 0;
                    int sideLength = 0;

                    while(i + sideLength < rows && j + sideLength < columns && sum <= threshold)
                    {
                        
                        for(int k = 0; k <= sideLength; k++)
                        {
                            sum += mat[i + sideLength][j + k];
                            sum += mat[i + k][j + sideLength];
                        }

                        sum -= mat[i + sideLength][j + sideLength];
                        sideLength++;
                    }

                    if(sum <= threshold)
                        maxSideLength = Math.Max(maxSideLength, sideLength);
                    else
                        maxSideLength = Math.Max(maxSideLength, sideLength - 1);
                }
            }

            return maxSideLength;
        }
    }

    public class Test
    {
        public static bool[] TestMaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold()
        {
            int[][] mat1 = new int[][]
            {
                new int[] {1, 1, 3, 2, 4, 3, 2},
                new int[] {1, 1, 3, 2, 4, 3, 2},
                new int[] {1, 1, 3, 2, 4, 3, 2}
            };

            int threshold1 = 4;

            int[][] mat2 = new int[][]
            {
                new int[] {2, 2, 2, 2, 2},
                new int[] {2, 2, 2, 2, 2},
                new int[] {2, 2, 2, 2, 2},
                new int[] {2, 2, 2, 2, 2},
                new int[] {2, 2, 2, 2, 2}
            };

            int threshold2 = 1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxSideLength(mat1, threshold1), 2),
                ResultTester.CheckResult<int>(Solution.MaxSideLength(mat2, threshold2), 0)
            };

            return results;
        }
    }
    
    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1292");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold());
        }
    }
}