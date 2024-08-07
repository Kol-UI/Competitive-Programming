//Rotate Image

/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.

 

Example 1:


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]


Example 2:


Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RotateImage
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int matrixLength = matrix.Length - 1; 
            List<int> lst = new();

            for (int i = 0; i <= matrixLength; i++)
            {
                for (int j = matrixLength; j >= 0; j--)
                {
                    lst.Add(matrix[j][i]);
                }
            }

            int index = 0;
            
            for(int i = 0; i <= matrixLength; i++)
            {
                for(int j = 0; j <= matrixLength; j++)
                {
                    matrix[i][j] = lst[index];
                    index ++;
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate Image");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}