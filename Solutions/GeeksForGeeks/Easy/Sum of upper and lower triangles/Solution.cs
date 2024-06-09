// Sum of upper and lower triangles

/*
Given a square matrix of size N*N, print the sum of upper and lower triangular elements. Upper Triangle consists of elements on the diagonal and above it. The lower triangle consists of elements on the diagonal and below it. 

Example 1:

Input:
N = 3 
mat[][] = {{6, 5, 4},
           {1, 2, 5}
           {7, 9, 7}}
Output: 
29 32
Explanation:
The given matrix is
6 5 4
1 2 5
7 9 7
The elements of upper triangle are
6 5 4
  2 5
    7
Sum of these elements is 6+5+4+2+5+7=29.
The elements of lower triangle are
6
1 2
7 9 7
Sum of these elements is 6+1+2+7+9+7= 32.
Example 2:

Input:
N = 2
mat[][] = {{1, 2},
           {3, 4}}
Output: 
7 8
Explanation:
Upper triangular matrix:
1 2
  4
Sum of these elements are 7.
Lower triangular matrix:
1
3 4
Sum of these elements are 8.

Your Task:
You don't need to read input or print anything. Complete the function sumTriangles() that takes matrix and its size N as input parameters and returns the list of integers containing the sum of upper and lower triangle.

Expected Time Complexity: O(N * N)
Expected Auxiliary Space: O(1)
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.Sumofupperandlowertriangles
{
    public class Solution
    {
        public static List<int> sumTriangles(List<List<int>> matrix, int n)
        {
            List<int> result = new();
            int upperSum = 0;
            int lowerSum = 0;
    
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        upperSum += matrix[i][j];
                    }
                    if (i >= j)
                    {
                        lowerSum += matrix[i][j];
                    }
                }
            }
    
            result.Add(upperSum);
            result.Add(lowerSum);
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int N1 = 3;
            List<List<int>> mat1 = new()
            {
                new List<int> {6, 5, 4},
                new List<int> {1, 2, 5},
                new List<int> {7, 9, 7}
            };

            List<int> result1 = new() { 29, 32 };

            int N2 = 2;
            List<List<int>> mat2 = new()
            {
                new List<int> {1, 2},
                new List<int> {3, 4}
            };

            List<int> result2 = new() { 7, 8 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<List<int>>(Solution.sumTriangles(mat1, N1), result1),
                ResultTester.CheckResult<List<int>>(Solution.sumTriangles(mat2, N2), result2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of upper and lower triangles");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestCases());
        }
    }
}