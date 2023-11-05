// Calculate average



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Calculateaverage
{
    public class Solution
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0 || array == null)
            {
                return 0;
            }
            else
            {
                double sum = 0.0;
                foreach (double value in array)
                {
                    sum += value;
                }

                double average = sum / array.Length;
                return average;
            }
        }

        public static double FindAverage2(double[] array) => array.Average();
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            double[] array1 = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            double result = Solution.FindAverage(array1);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(Solution.FindAverage(array1), result),
                ResultTester.CheckResult<double>(Solution.FindAverage2(array1), result),
            };
            return results;
        }
    }
}