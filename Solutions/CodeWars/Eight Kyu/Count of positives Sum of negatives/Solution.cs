// Count of positives Sum of negatives
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.CountofpositivesSumofnegatives
{
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[]? input)
        {
            if (input == null || input.Length == 0)
            {
                return Array.Empty<int>();
            }

            int countPositives = 0;
            int sumNegatives = 0;

            foreach (int num in input)
            {
                if (num > 0)
                {
                    countPositives++;
                }
                else if (num < 0)
                {
                    sumNegatives += num;
                }
            }

            return new int[] { countPositives, sumNegatives };
        }

        public static int[] CountPositivesSumNegativesCleaver(int[]? input)    
        {   
            return (input == null || input.Length ==0) ? new int[0] : new int[] { input.Count(o => o > 0), input.Where(o => o < 0).Sum() };
        }

        public static int[] CountPositivesSumNegativesBestPractices(int[]? input)
        {
            if(input == null || !input.Any())
            {
                return new int[] {};
            }
            
            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] expectedResult1 = new int[] {10, -65};
            int[] expectedResult2 = new int[] {8, -50};
            int[] expectedResult3 = new int[] {};
            int[] expectedResult4 = new int[] {};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegatives(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15}), expectedResult1),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegatives(new[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}), expectedResult2),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegatives(null), expectedResult3),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegatives(new int[] {}), expectedResult4),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesCleaver(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15}), expectedResult1),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesCleaver(new[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}), expectedResult2),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesCleaver(null), expectedResult3),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesCleaver(new int[] {}), expectedResult4),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesBestPractices(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15}), expectedResult1),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesBestPractices(new[] {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}), expectedResult2),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesBestPractices(null), expectedResult3),
                ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesBestPractices(new int[] {}), expectedResult4),
            };

            for(int i = 0; i < 100; i++)
            {
                int[] values = RandomGeneraters.GenerateRandomNumber(100, 100);
                bool test = ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegatives(values), Kata.CountPositivesSumNegatives(values));
                results.Append(test);
            }

            for(int i = 0; i < 100; i++)
            {
                int[] values = RandomGeneraters.GenerateRandomNegativeNumber(100);
                bool test = ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegatives(values), Kata.CountPositivesSumNegatives(values));
                results.Append(test);
            }

            for(int i = 0; i < 100; i++)
            {
                int[] values = RandomGeneraters.GenerateRandomNumber(100, 100);
                bool test = ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesCleaver(values), Kata.CountPositivesSumNegativesCleaver(values));
                results.Append(test);
            }

            for(int i = 0; i < 100; i++)
            {
                int[] values = RandomGeneraters.GenerateRandomNegativeNumber(100);
                bool test = ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesCleaver(values), Kata.CountPositivesSumNegativesCleaver(values));
                results.Append(test);
            }

            for(int i = 0; i < 100; i++)
            {
                int[] values = RandomGeneraters.GenerateRandomNumber(100, 100);
                bool test = ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesBestPractices(values), Kata.CountPositivesSumNegativesBestPractices(values));
                results.Append(test);
            }

            for(int i = 0; i < 100; i++)
            {
                int[] values = RandomGeneraters.GenerateRandomNegativeNumber(100);
                bool test = ResultTester.CheckResult<int[]>(Kata.CountPositivesSumNegativesBestPractices(values), Kata.CountPositivesSumNegativesBestPractices(values));
                results.Append(test);
            }

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count of positives Sum of negatives");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}