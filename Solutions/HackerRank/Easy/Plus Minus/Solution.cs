using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.PlusMinus
{
    public class Solution
    {
        public static void plusMinus(List<int> arr)
        {
            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;

            for (int arr_i = 0; arr_i < arr.Count; arr_i++)
            {
                if (arr[arr_i] > 0)
                    ++positiveNumbers;
                else if (arr[arr_i] < 0)
                    ++negativeNumbers;
                else
                    ++zeroNumbers;
            }

            double totalElements = arr.Count;
            Console.WriteLine((positiveNumbers / totalElements).ToString("F6"));
            Console.WriteLine((negativeNumbers / totalElements).ToString("F6"));
            Console.WriteLine((zeroNumbers / totalElements).ToString("F6"));
        }
    }

    public class Test
    {
        public static List<string> plusMinus(List<int> arr)
        {
            var positiveNumbers = 0;
            var negativeNumbers = 0;
            var zeroNumbers = 0;

            for (int arr_i = 0; arr_i < arr.Count; arr_i++)
            {
                if (arr[arr_i] > 0)
                    ++positiveNumbers;
                else if (arr[arr_i] < 0)
                    ++negativeNumbers;
                else
                    ++zeroNumbers;
            }

            double totalElements = arr.Count;
            // Test Part
            List<string> ratios = new List<string>();
            ratios.Add((positiveNumbers / (double)totalElements).ToString("F6"));
            ratios.Add((negativeNumbers / (double)totalElements).ToString("F6"));
            ratios.Add((zeroNumbers / (double)totalElements).ToString("F6"));

            return ratios;
        }

        public static bool[] TestPlusMinus()
        {
            List<int> list = new List<int> { -4, 3, -9, 0, 4, 1 };
            List<string> result = Test.plusMinus(list);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<List<string>>(result, result)
            };
            return results;
        }
    }

}
