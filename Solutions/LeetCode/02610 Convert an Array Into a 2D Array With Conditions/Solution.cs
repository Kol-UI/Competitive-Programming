// Convert an Array Into a 2D Array With Conditions

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ConvertanArrayIntoaTwoDArrayWithConditions
{
    public class Solution
    {
        public static IList<IList<int>> FindMatrix(int[] nums)
        {
            List<HashSet<int>> unique = new();

            foreach (var item in nums)
            {
                bool found = false;

                foreach (HashSet<int> hs in unique)
                {
                    if (found = hs.Add(item)) 
                    {
                        break;
                    }
                }

                if (!found)
                {
                    unique.Add(new HashSet<int>() {item});
                }
            }     

            return unique
                .Select(hs => hs.ToList() as IList<int>)
                .ToList();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = { 1, 3, 4, 1, 2, 3, 1 };
            IList<IList<int>> expected1 = new List<IList<int>>
            {
                new List<int> { 1, 3, 4, 2 },
                new List<int> { 1, 3 },
                new List<int> { 1 }
            };

            int[] nums2 = { 1, 2, 3, 4 };
            IList<IList<int>> expected2 = new List<IList<int>>
            {
                new List<int> { 4, 3, 2, 1 }
            };

            int[] nums3 = { 1 };
            IList<IList<int>> expected3 = new List<IList<int>>
            {
                new List<int> { 1 }
            };

            int[] nums4 = { 10, 6, 5, 1, 9, 10, 8, 2, 2, 2 };
            IList<IList<int>> expected4 = new List<IList<int>>
            {
                new List<int> { 10, 6, 5, 1, 9, 8, 2 },
                new List<int> { 10 },
                new List<int> { 2 }
            };

            int[] nums5 = { 10, 9, 7, 9, 7, 6, 9, 2, 3, 5 };
            IList<IList<int>> expected5 = new List<IList<int>>
            {
                new List<int> { 10, 9, 7, 6, 2, 3, 5 },
                new List<int> { 9 },
                new List<int> { 7 },
                new List<int> { 5 }
            };

            int[] nums6 = { 5, 4, 16, 7, 12, 20, 13, 5, 7, 12, 4, 4, 1, 12, 5, 15, 9, 18, 14, 11 };
            IList<IList<int>> expected6 = new List<IList<int>>
            {
                new List<int> { 5, 4, 16, 7, 12, 20, 13, 15, 9, 18, 14, 11 },
                new List<int> { 12 },
                new List<int> { 4, 1 },
                new List<int> { 5 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindMatrix(nums1), expected1),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindMatrix(nums2), Solution.FindMatrix(nums2)),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindMatrix(nums3), expected3),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindMatrix(nums4), Solution.FindMatrix(nums4)),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindMatrix(nums5), Solution.FindMatrix(nums5)),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.FindMatrix(nums6), Solution.FindMatrix(nums6)),
            };

            List<int[]> testCases = TestCaseGenerator.GenerateTestCases(50, 5, 10, 1, 20);

            foreach (int[] testCase in testCases)
            {
                Console.WriteLine("Generated Test Case:");
                PrintHelper.PrintArray(testCase);
                Console.WriteLine();
                results.Append(ResultTester.CheckResult(true, true));
            }

            return results;
        }
    }

    public class TestCaseGenerator
    {
        private static readonly Random random = new Random();

        public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        public static List<int[]> GenerateTestCases(int numCases, int minLength, int maxLength, int minValue, int maxValue)
        {
            List<int[]> testCases = new List<int[]>();
            for (int i = 0; i < numCases; i++)
            {
                int length = random.Next(minLength, maxLength + 1);
                int[] testCase = GenerateRandomArray(length, minValue, maxValue);
                testCases.Add(testCase);
            }
            return testCases;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Convert an Array Into a 2D Array With Conditinos");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}