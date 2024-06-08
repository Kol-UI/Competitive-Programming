using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.Sumofpositive
{
	public class Solution
	{
        // You get an array of numbers, return the sum of all of the positives ones.
        // Example [1,-4,7,12] => 1 + 7 + 12 = 20
        // Note: if there is nothing to sum, the sum is default to 0.

        public static int PositiveSum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        // Clever
        public static int CleverPositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }

    public class Test
    {
        public static bool[] TestYouCantCodeUnderPressure1()
        {
            System.Random random = new System.Random();

            // Case 1
            int[] arrCase1 = { 1, 2, 3, 4, 5};
            int Case1_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase1);

            // Case 2
            int[] arrCase2 = { 1, -2, 3, 4, 5};
            int Case2_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase2);

            // Case 3
            int[] arrCase3 = { -1, 2, 3, 4, -5};
            int Case3_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase3);

            // Case 4
            int[] arrCase4 = {};
            int Case4_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase4);

            // Case 5
            int value1 = random.Next(-5, 5);
            int value2 = random.Next(-5, 5);
            int value3 = random.Next(-5, 5);
            int value4 = random.Next(-5, 5);
            int value5 = random.Next(-5, 5);
            int[] arrCase5 = { value1, value2, value3, value4, value5};
            int Case5_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase5);

            // Case 6
            int[] arrCase6 = { 1, -4, 7, 12};
            int Case6_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase6);

            // Clever
            // Case 1
            int Case1_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase1);

            // Case 2
            int Case2_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase2);

            // Case 3
            int Case3_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase3);

            // Case 4
            int Case4_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase4);

            // Case 5
            int Case5_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase5);

            // Case 6
            int Case6_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase6);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_Result, 15),
                ResultTester.CheckResult<int>(Case2_Result, 13),
                ResultTester.CheckResult<int>(Case3_Result, 9),
                ResultTester.CheckResult<int>(Case4_Result, 0),
                ResultTester.CheckResult<int>(Case5_Result, Case5_CleverResult),
                ResultTester.CheckResult<int>(Case6_Result, 20),
                ResultTester.CheckResult<int>(Case1_CleverResult, 15),
                ResultTester.CheckResult<int>(Case2_CleverResult, 13),
                ResultTester.CheckResult<int>(Case3_CleverResult, 9),
                ResultTester.CheckResult<int>(Case4_CleverResult, 0),
                ResultTester.CheckResult<int>(Case5_CleverResult, Case5_Result),
                ResultTester.CheckResult<int>(Case6_CleverResult, 20),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of positive");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestYouCantCodeUnderPressure1());
        }
    }
}