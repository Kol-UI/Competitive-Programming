// Row With Maximum Ones


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.RowWithMaximumOnes
{
    public class Solution
    {
        public static int[] RowAndMaximumOnes(int[][] mat)
        {
            int count = 0;
            var res = new List<int>();

            for(int i = 0;i < mat.Length; i++)
            {
                for(int j = 0; j < mat[i].Length; j++)
                {
                    if(mat[i][j] == 1)
                    {
                        count++;
                    }
                }
                res.Add(count);
                count = 0;
            }

            int maxValue = res.Max();
            int maxIndex = res.IndexOf(maxValue);
            
            
            int[] result = {maxIndex, maxValue};

            return result;
        }
    }
    
    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 1 }
            };

            int[][] matrix3 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 0, 1 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.RowAndMaximumOnes(matrix1), new int[]{0,1}),
                ResultTester.CheckResult<int[]>(Solution.RowAndMaximumOnes(matrix2), new int[]{1,2}),
                ResultTester.CheckResult<int[]>(Solution.RowAndMaximumOnes(matrix3), new int[]{1,2}),
            };
            return results;
        }
    }
}