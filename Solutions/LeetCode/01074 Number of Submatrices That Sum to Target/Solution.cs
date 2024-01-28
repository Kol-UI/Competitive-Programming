// Number of Submatrices That Sum to Target

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofSubmatricesThatSumtoTarget
{
    public class Solution
    {
        public static int NumSubmatrixSumTarget(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int result = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 1; j < n; j++) 
                {
                    matrix[i][j] += matrix[i][j - 1];
                }
            }

            for (int left = 0; left < n; left++) 
            {
                for (int right = left; right < n; right++) 
                {
                    int currentSum = 0;
                    Dictionary<int, int> prefixSumCount = new Dictionary<int, int>();
                    prefixSumCount[0] = 1;

                    for (int row = 0; row < m; row++)
                    {
                        int rowSum = matrix[row][right] - (left > 0 ? matrix[row][left - 1] : 0);
                        currentSum += rowSum;

                        if (prefixSumCount.ContainsKey(currentSum - target))
                        {
                            result += prefixSumCount[currentSum - target];
                        }

                        if (prefixSumCount.ContainsKey(currentSum))
                        {
                            prefixSumCount[currentSum]++;
                        } 
                        else 
                        {
                            prefixSumCount[currentSum] = 1;
                        }
                    }
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0,1,0 },
                new int[] { 1,1,1 },
                new int[] { 0,1,0 },
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1,-1 },
                new int[] { -1,1 },
            };

            int[][] matrix3 = new int[][]
            {
                new int[] { 904 },
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumSubmatrixSumTarget(matrix1, 0), 4),
                ResultTester.CheckResult<int>(Solution.NumSubmatrixSumTarget(matrix2, 0), 5),
                ResultTester.CheckResult<int>(Solution.NumSubmatrixSumTarget(matrix3, 0), 0),
            };

            return results;
        }
    }
}