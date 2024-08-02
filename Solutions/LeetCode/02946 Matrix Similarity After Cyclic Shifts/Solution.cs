// Matrix Similarity After Cyclic Shifts

/*
You are given a 0-indexed m x n integer matrix mat and an integer k. You have to cyclically right shift odd indexed rows k times and cyclically left shift even indexed rows k times.

Return true if the initial and final matrix are exactly the same and false otherwise.

 

Example 1:

Input: mat = [[1,2,1,2],[5,5,5,5],[6,3,6,3]], k = 2
Output: true
Explanation:


Initially, the matrix looks like the first figure. 
Second figure represents the state of the matrix after one right and left cyclic shifts to even and odd indexed rows.
Third figure is the final state of the matrix after two cyclic shifts which is similar to the initial matrix.
Therefore, return true.

Example 2:

Input: mat = [[2,2],[2,2]], k = 3
Output: true
Explanation: As all the values are equal in the matrix, even after performing cyclic shifts the matrix will remain the same. Therefeore, we return true.

Example 3:

Input: mat = [[1,2]], k = 1
Output: false
Explanation: After one cyclic shift, mat = [[2,1]] which is not equal to the initial matrix. Therefore we return false.

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MatrixSimilarityAfterCyclicShifts
{
    public class Solution
    {
        public static bool AreSimilar(int[][] mat, int k)
        {
            k %= mat[0].Length;
            if (k == 0)
            {
                return true;
            }
            
            for (int i = 0; i < mat.Length; i++)
            {
                int col = (i % 2 == 1) ? mat[0].Length - k : k;
                for (int j = 0; j < mat[i].Length; j++, col = (col + 1) % mat[i].Length)
                    if (mat[i][j] != mat[i][col])
                        return false;
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] {1, 2, 1, 2},
                new int[] {5, 5, 5, 5},
                new int[] {6, 3, 6, 3}
            };
            int[][] matrix2 = new int[][]
            {
                new int[] {2, 2},
                new int[] {2, 2}
            };
            int[][] matrix3 = new int[][]
            {
                new int[] {1, 2}
            };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.AreSimilar(matrix1, 2), true),
                ResultTester.CheckResult<bool>(Solution.AreSimilar(matrix2, 3), true),
                ResultTester.CheckResult<bool>(Solution.AreSimilar(matrix2, 1), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2946");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}