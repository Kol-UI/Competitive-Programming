// Determine Whether Matrix Can Be Obtained By Rotation

/*
Given two n x n binary matrices mat and target, return true if it is possible to make mat equal to target by rotating mat in 90-degree increments, or false otherwise.

 

Example 1:


Input: mat = [[0,1],[1,0]], target = [[1,0],[0,1]]
Output: true
Explanation: We can rotate mat 90 degrees clockwise to make mat equal target.


Example 2:


Input: mat = [[0,1],[1,1]], target = [[1,0],[0,1]]
Output: false
Explanation: It is impossible to make mat equal to target by rotating mat.


Example 3:


Input: mat = [[0,0,0],[0,1,0],[1,1,1]], target = [[1,1,1],[0,1,0],[0,0,0]]
Output: true
Explanation: We can rotate mat 90 degrees clockwise two times to make mat equal target.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DetermineWhetherMatrixCanBeObtainedByRotation
{
    public class Solution
    {
        public static bool FindRotation(int[][] mat, int[][] target)
        {
            int len = mat.Length;
            int half_len = len / 2;

            for(int a = 0; a < 4; a++)
            {
                if(isMatrixEqual(len,mat,target))
                {
                    return true;
                }
                rotate(len, half_len, mat);
            }
            return false;   
        }
        
        public static void rotate(int len, int half_len, int[][] mat)
        {
            for(int i = 0; i < half_len; i++)
            {
                for(int j = i; j < len - i - 1; j++)
                {
                    int temp = mat[i][j];
                    
                    mat[i][j] = mat[len-j-1][i];
                    mat[len-j-1][i] = mat[len-i-1][len-j-1];
                    mat[len-i-1][len-j-1] = mat[j][len-i-1];
                    mat[j][len-i-1] = temp;
                }
            }
        }
        
        public static bool isMatrixEqual(int len, int[][]mat, int[][]target)
        {
            for(int i = 0; i < len; i++)
            {
                for(int j = 0; j < len; j++)
                {
                    if(mat[i][j] != target[i][j])
                        return false;
                }
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
                new int[] {0, 1},
                new int[] {1, 0}
            };

            int[][] target1 = new int[][]
            {
                new int[] {1, 0},
                new int[] {0, 1}
            };

            int[][] matrix2 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 1}
            };

            int[][] target2 = new int[][]
            {
                new int[] {1, 0},
                new int[] {0, 1}
            };

            int[][] matrix3 = new int[][]
            {
                new int[] {0, 0, 0},
                new int[] {0, 1, 0},
                new int[] {1, 1, 1}
            };

            int[][] target3 = new int[][]
            {
                new int[] {1, 1, 1},
                new int[] {0, 1, 0},
                new int[] {0, 0, 0}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.FindRotation(matrix1, target1), true),
                ResultTester.CheckResult<bool>(Solution.FindRotation(matrix2, target2), false),
                ResultTester.CheckResult<bool>(Solution.FindRotation(matrix3, target3), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1886");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}