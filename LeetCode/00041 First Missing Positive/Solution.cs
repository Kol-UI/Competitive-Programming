// First Missing Positive

/*
Given an unsorted integer array nums, return the smallest missing positive integer.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

 

Example 1:

Input: nums = [1,2,0]
Output: 3
Explanation: The numbers in the range [1,2] are all in the array.


Example 2:

Input: nums = [3,4,-1,1]
Output: 2
Explanation: 1 is in the array but 2 is missing.


Example 3:

Input: nums = [7,8,9,11,12]
Output: 1
Explanation: The smallest positive integer 1 is missing.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FirstMissingPositive
{
    public class Solution
    {
        public static int FirstMissingPositive(int[] nums)
        {
            HashSet<int> h = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] > 0)
                    h.Add(nums[i]);
                    
            for (int i = 1;;i++)
            {
                if (!h.Contains(i))
                    return i;
            }
        }
    }

    public class Test
    {
        public static bool[] TestFirstMissingPositive()
        {
            int[] nums64 = {1,2,0};
            int[] nums65 = {3,4,-1,1};
            int[] nums66 = {7,8,9,11,12};
            int[] case1 = {-1, -2, -3, -4, 3, 2, 1};
            int[] case2 = {1, 5, 0, 2, -3};
            int[] case3 = {-1, 1, -1, 1, -1};
            int[] case4 = {1000, 2000, 3000};
            int[] case5 = {4000, 3000, 1000, 2000};
            int[] case6 = {3, 5, 1};
            int[] case7 = {1, 2, 4};
            int[] case8 = {1, 2, 2, 3};
            int[] case9 = {6, 5, 4, 4};
            int[] case10 = {1, 3, 2};
            int[] case11 = {30, 11, 23, 4, 20};
            int[] case12 = {3, 6, 7, 11};
            int[] case13 = {-30, -11, 23, 4, 20};
            int[] case14 = {-10, -3, 0, 5, 9};
            int[] case15 = {1, 3};
            int[] case16 = {1, 2, 2};
            int[] case17 = {1, 2};
            int[] case18 = {5, 3, 4};
            int[] case19 = Program.GenerateRandomNumber(10, 100);
            int[] case20 = Program.GenerateRandomNumber(10, 100);
            int[] case21 = Program.GenerateRandomNumber(10, 100);
            int[] case22 = Program.GenerateRandomNumber(10, 100);
            int[] case23 = Program.GenerateRandomNegativeNumber(100);
            int[] case24 = Program.GenerateRandomNegativeNumber(100);
            int[] case25 = Program.GenerateRandomNegativeNumber(100);
            int[] case26 = Program.GenerateRandomNegativeNumber(100);
            int[] case27 = {-1, -2};
            int[] case28 = {78, 56, 232, 12, 11, 43};
            int[] case29 = {78, 56, -2, 12, 8, -33};
            int[] case30 = {34, 15, 88, 2};
            int[] case31 = {34, -345, -1, 100};
            int[] case32 = {12, 35, 1, 10, 34, 1};
            int[] case33 = {10, 5, 10};
            int[] case34 = {1, 0, 0, 0, 1};
            int[] case35 = {1, 0, 0, 0, 0, 0, 1};
            int[] case36 = {1, 3, 0, 0, 2, 0, 0, 4};
            int[] case37 = {0, 0, 0, 2, 0, 0};
            int[] case38 = {1, 2, 3, 4};
            int[] case39 = {-1, 1, 0, -3, 3};
            int[] case40 = {1, 2, 3, 4, 5};
            int[] case41 = {5, 4, 3, 2, 1};
            int[] case42 = {2, 1, 5, 0, 4, 6};
            int[] case43 = {3, 2, 1, 5, 6, 4};
            int[] case44 = {3, 2, 3, 1, 2, 4, 5, 5, 6};
            int[] case45 = {1, 3, 3, 2};
            int[] case46 = {2, 1, 3, 4};
            int[] case47 = {4, 2, 3, 1, 1};
            int[] case48 = {7, 5, 10, 9, 6};
            int[] case49 = {1, 2, 3};
            int[] case50 = {4, 1, 1, 1, 4};
            int[] case51 = {2, 2, 2, 2, 2, 2};
            int[] case52 = {2, 4, 6};
            int[] case53 = {2, 4, 6};
            int[] case54 = {8, 2, 2, 2, 8};
            int[] case55 = {4, 4, 4, 4, 4, 4};
            int[] case56 = {4, 6, 5, 9, 3, 7};
            int[] case57 = {0, 0, 2};
            int[] case58 = {2, 3, 5};
            int[] case59 = {-12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10};
            int[] case60 = {0, 1, 6, 4, 8, 7};
            int[] case61 = {4, 4, 9, 7, 9, 10};
            int[] case62 = {1, 5, 11, 5};
            int[] case63 = {1, 2, 3, 5};

            int[][] allCases = new int[][]
            {
                case1, case2, case3, case4, case5, case6, case7, case8, case9, case10,
                case11, case12, case13, case14, case15, case16, case17, case18, case19, case20,
                case21, case22, case23, case24, case25, case26, case27, case28, case29, case30,
                case31, case32, case33, case34, case35, case36, case37, case38, case39, case40,
                case41, case42, case43, case44, case45, case46, case47, case48, case49, case50,
                case51, case52, case53, case54, case55, case56, case57, case58, case59, case60,
                case61, case62, case63, nums64, nums65, nums66
            };

            int[] results = new int[allCases.Length];

            for (int i = 0; i < allCases.Length; i++)
            {
                int[] currentCase = allCases[i];
                int currentResult = Solution.FirstMissingPositive(currentCase);
                results[i] = currentResult;
            }

            bool[] resultBooleans = new bool[results.Length];

            for (int i = 0; i < results.Length; i++)
            {
                resultBooleans[i] = ResultTester.CheckResult<int>(results[i], results[i]);
            }
            return resultBooleans;
        }
    }
}