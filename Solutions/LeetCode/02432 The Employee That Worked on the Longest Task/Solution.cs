// The Employee That Worked on the Longest Task


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TheEmployeeThatWorkedontheLongestTask
{
    public class Solution
    {
        public static int HardestWorker(int n, int[][] logs)
        {
            int prior = 0;
            int max = 0;
            int result = 0;

            foreach (int[] item in logs)
            {
                int value = item[1] - prior;

                if (value > max || value == max && result > item[0])
                {
                    max = value;
                    result = item[0];
                }
                
                prior = item[1];
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
                new int[] { 0, 3 },
                new int[] { 2, 5 },
                new int[] { 0, 9 },
                new int[] { 1, 15 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 7 },
                new int[] { 2, 12 },
                new int[] { 7, 17 }
            };

            int[][] matrix3 = new int[][]
            {
                new int[] { 0, 10 },
                new int[] { 1, 20 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.HardestWorker(10, matrix1), 1),
                ResultTester.CheckResult<int>(Solution.HardestWorker(26, matrix2), 3),
                ResultTester.CheckResult<int>(Solution.HardestWorker(2, matrix3), 0),
            };
            return results;
        }
    }
}