using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.SumArray
{
    public class Solution
    {
        //Write a function that takes an array of numbers and returns the sum of the numbers.
        //The numbers can be negative or non-integer.If the array does not contain any numbers then you should return 0.

        //Examples
        //        Input: [1, 5.2, 4, 0, -1]
        //        Output: 9.2

        //Input: []
        //        Output: 0

        //Input: [-2.398]
        //        Output: -2.398

        public static double SumArray(double[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            else
            {
                return array.Sum();
            }
        }
    }

    public class Test
    {
        public static bool[] TestSumArray()
        {
            // Case 1
            double[] sumArrayCase1 = { 10, 20, 30, 40 };
            double sumArrayResultCase1 = Solution.SumArray(sumArrayCase1);

            // Case 2
            double[] sumArrayCase2 = Array.Empty<double>();
            double sumArrayResultCase2 = Solution.SumArray(sumArrayCase2);

            // Case 3
            double[] sumArrayCase3 = { 0 };
            double sumArrayResultCase3 = Solution.SumArray(sumArrayCase3);

            // Case 4
            double[] sumArrayCase4 = { 1, 5.2, 4, 0, -1 };
            double sumArrayResultCase4 = Solution.SumArray(sumArrayCase4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(sumArrayResultCase1, 100),
                ResultTester.CheckResult<double>(sumArrayResultCase2, 0),
                ResultTester.CheckResult<double>(sumArrayResultCase3, 0),
                ResultTester.CheckResult<double>(sumArrayResultCase4, 9.2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestSumArray());
        }
    }
}