// Invert Values

/*
Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
invert([]) == []
*/

using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.InvertValues
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = -input[i];
            }

            return input;
        }

        public static int[] InvertValuesBestPractices(int[] input)
        {
            return input.Select(n => -n).ToArray();
        }

        public static int[] InvertValuesSelect(int[] input)
        {
            return input.Select(x => -x).ToArray();
        }

        public static int[] InvertValuesLoopComparison(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] < 0)
                {
                    input[i] = input[i] * -1;
                }
                else
                {
                    input[i] = -input[i];
                }
            }
            return input;
        }
    }

    public class Test
    {
        private static Random rand = new Random();

        public static bool[] TestCases()
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] expected1 = {1, 2, 3, 4, 5};
            int[] expected1_1 = { -1, -2, -3, -4, -5 };

            int[] numbers2 = { 1, -2, 3, -4, 5 };
            int[] expected2 = {1, -2, 3, -4, 5};
            int[] expected2_1 = { -1, 2, -3, 4, -5 };

            int[] emptyArray = { };

            int[] zeroArray = { 0 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValues(numbers1), expected1_1),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValues(numbers2), expected2_1),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValues(emptyArray), emptyArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValues(zeroArray), zeroArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesBestPractices(numbers1), expected1),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesBestPractices(numbers2), expected2),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesBestPractices(emptyArray), emptyArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesBestPractices(zeroArray), zeroArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesSelect(numbers1), expected1),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesSelect(numbers2), expected2),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesSelect(emptyArray), emptyArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesSelect(zeroArray), zeroArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesLoopComparison(numbers1), expected1),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesLoopComparison(numbers2), expected2),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesLoopComparison(emptyArray), emptyArray),
                ResultTester.CheckResult<int[]>(ArraysInversion.InvertValuesLoopComparison(zeroArray), zeroArray),
            };

            var rdn = new Test();
            bool[] randomTests = rdn.RandomTests();

            return results.Concat(randomTests).ToArray();
        }


        private static int[] Solve(int[] input)
        {
            return input.Select(x => x*(-1)).ToArray();
        }
        
        private static int[] GenerateArr()
        {
            List<int> numbers = new List<int>(); 
            int n = rand.Next(5, 100);
            for(int i = 0; i < n; i++)
            {
                numbers.Add(rand.Next(-100, 100));
            }
            return numbers.ToArray();
        }
        
        public bool[] RandomTests()
        {
            bool[] results = {};
            Random rand = new Random();

            // InvertValues
            for (int i = 0; i < 100; i++)
            {
                int[] arr = GenerateArr();
                int[] result = Solve(arr);
                int[] expected = ArraysInversion.InvertValues(arr);
                results.Append(ResultTester.CheckResult<int[]>(result, expected));
            }

            // InvertValuesBestPractices
            for (int i = 0; i < 100; i++)
            {
                int[] arr = GenerateArr();
                int[] result = Solve(arr);
                int[] expected = ArraysInversion.InvertValuesBestPractices(arr);
                results.Append(ResultTester.CheckResult<int[]>(result, expected));
            }

            // InvertValuesLoopComparison
            for (int i = 0; i < 100; i++)
            {
                int[] arr = GenerateArr();
                int[] result = Solve(arr);
                int[] expected = ArraysInversion.InvertValuesLoopComparison(arr);
                results.Append(ResultTester.CheckResult<int[]>(result, expected));
            }

            // InvertValuesSelect
            for (int i = 0; i < 100; i++)
            {
                int[] arr = GenerateArr();
                int[] result = Solve(arr);
                int[] expected = ArraysInversion.InvertValuesSelect(arr);
                results.Append(ResultTester.CheckResult<int[]>(result, expected));
            } 

            return results;
        } 
    }
}

