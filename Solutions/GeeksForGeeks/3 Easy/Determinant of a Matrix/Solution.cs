// Determinant of a Matrix



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.DeterminantofaMatrix
{
    class Solution
    {
        public static int determinantOfMatrix(List<List<int>> matrix, int n)
        {
            int D = 0;

            if (n == 1)
                return matrix[0][0];

            List<List<int>> temp = new();

            for (int i = 0; i < n; i++)
            {
                temp.Add(new List<int>());
                for (int j = 0; j < n; j++)
                {
                    temp[i].Add(0);
                }
            }

            int sign = 1;

            for (int f = 0; f < n; f++)
            {
                getCofactor(matrix, temp, 0, f, n);
                D += sign * matrix[0][f] * determinantOfMatrix(temp, n - 1);
                sign = -sign;
            }

            return D;
        }

        private static void getCofactor(List<List<int>> mat, List<List<int>> temp, int p, int q, int n)
        {
            int i = 0, j = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row != p && col != q)
                    {
                        temp[i][j++] = mat[row][col];

                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            List<List<int>> matrix1 = new List<List<int>>
            {
                new List<int> { 1, 0, 2 },
                new List<int> { -1, 3, 0 },
                new List<int> { 0, 5, 2 }
            };

            List<List<int>> matrix2 = new List<List<int>>
            {
                new List<int> { 2, 4, 5 },
                new List<int> { 3, -2, 1 },
                new List<int> { 0, 7, 9 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.determinantOfMatrix(matrix1, 3), -4),
                ResultTester.CheckResult<int>(Solution.determinantOfMatrix(matrix2, 3), -53),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determinant of a Matrix");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestCases());
        }
    }
}