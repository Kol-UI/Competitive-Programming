using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthMissingPositiveNumber
{
    // Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
    // Return the kth positive integer that is missing from this array.

    // Example 1:
    // Input: arr = [2,3,4,7,11], k = 5
    // Output: 9
    // Explanation: The missing positive integers are [1,5,6,8,9,10,12,13,...]. The 5th missing positive integer is 9.
    // Example 2:

    // Input: arr = [1,2,3,4], k = 2
    // Output: 6
    // Explanation: The missing positive integers are [5,6,7,...]. The 2nd missing positive integer is 6.

    public class Solution
    {
        public static int FindKthPositive(int[] arr, int k)
        {
            var left = 0;
            var right = arr.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] - mid - 1 < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left + k;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] arrCase1_1539 = { 2, 3, 4, 7, 11 };
            int kCase1_1539 = 5;
            int resultCase1_1345 = Solution.FindKthPositive(arrCase1_1539, kCase1_1539);

            // Case 2
            int[] arrCase2_1539 = { 1, 2, 3, 4 };
            int kCase2_1539 = 2;
            int resultCase2_1345 = Solution.FindKthPositive(arrCase2_1539, kCase2_1539);

            // Case 3
            int[] arrCase3_1539 = { 1, 2, 3, 4, 9, 10, 12, 17 };
            int kCase3_1539 = 6;
            int resultCase3_1345 = Solution.FindKthPositive(arrCase3_1539, kCase3_1539);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_1345, 9),
                ResultTester.CheckResult<int>(resultCase2_1345, 6),
                ResultTester.CheckResult<int>(resultCase3_1345, resultCase3_1345)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Missing Positive Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}