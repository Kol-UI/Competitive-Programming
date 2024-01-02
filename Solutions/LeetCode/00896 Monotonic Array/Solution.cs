// Monotonic Array

/*
An array is monotonic if it is either monotone increasing or monotone decreasing.

An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].

Given an integer array nums, return true if the given array is monotonic, or false otherwise.

 

Example 1:

Input: nums = [1,2,2,3]
Output: true

Example 2:

Input: nums = [6,5,4,4]
Output: true

Example 3:

Input: nums = [1,3,2]
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MonotonicArray
{
    public class Solution
    {
        public static bool IsMonotonic(int[] nums)
        {
            var toBig = true;
            var toSmall = true;
            var last = nums[0];

            foreach(var num in nums)
            {
                if (num > last)
                {
                    toSmall = false;
                }
                else if (num < last)
                {
                    toBig = false;
                }
                last = num;
            }
            return (toBig || toSmall);
        }
    }

    public class Test
    {
        public static bool[] TestMonotonicArray()
        {
            int[] Case1 = {-1,-2,-3,-4,3,2,1};
            int[] Case2 = {1,5,0,2,-3};
            int[] Case3 = {-1,1,-1,1,-1};
            int[] Case4 = {1000,2000,3000};
            int[] Case5 = {4000,3000,1000,2000};
            int[] Case6 = {3,5,1};
            int[] Case7 = {1,2,4};
            int[] Case8 = {1,2,2,3};
            int[] Case9 = {6,5,4,4};
            int[] Case10 = {1,3,2};
            int[] Case11 = { 30, 11, 23, 4, 20 };
            int[] Case12 = { 3, 6, 7, 11 };
            int[] Case13 = { -30, -11, 23, 4, 20 };
            int[] Case14 = { -10, -3, 0, 5, 9 };
            int[] Case15 = { 1, 3 };
            int[] Case16 = { 1, 2, 2 };
            int[] Case17 = { 1, 2 };
            int[] Case18 = { 5, 3, 4 };
            int[] Case19 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case20 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case21 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case22 = RandomGeneraters.GenerateRandomNumber(10, 100);
            int[] Case23 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case24 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case25 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case26 = RandomGeneraters.GenerateRandomNegativeNumber(100);
            int[] Case27 = { -1, -2 };
            int[] Case28 = { 78, 56, 232, 12, 11, 43 };
            int[] Case29 = { 78, 56, -2, 12, 8, -33 };
            int[] Case30 = { 34, 15, 88, 2 };
            int[] Case31 = { 34, -345, -1, 100 };
            int[] Case32 = { 12, 35, 1, 10, 34, 1 };
            int[] Case33 = { 10, 5, 10 };
            int[] Case34 = { 1, 0, 0, 0, 1 };
            int[] Case35 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] Case36 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            int[] Case37 = { 0, 0, 0, 2, 0, 0 };

            bool result1 = Solution.IsMonotonic(Case1);
            bool result2 = Solution.IsMonotonic(Case2);
            bool result3 = Solution.IsMonotonic(Case3);
            bool result4 = Solution.IsMonotonic(Case4);
            bool result5 = Solution.IsMonotonic(Case5);
            bool result6 = Solution.IsMonotonic(Case6);
            bool result7 = Solution.IsMonotonic(Case7);
            bool result8 = Solution.IsMonotonic(Case8);
            bool result9 = Solution.IsMonotonic(Case9);
            bool result10 = Solution.IsMonotonic(Case10);
            bool result11 = Solution.IsMonotonic(Case11);
            bool result12 = Solution.IsMonotonic(Case12);
            bool result13 = Solution.IsMonotonic(Case13);
            bool result14 = Solution.IsMonotonic(Case14);
            bool result15 = Solution.IsMonotonic(Case15);
            bool result16 = Solution.IsMonotonic(Case16);
            bool result17 = Solution.IsMonotonic(Case17);
            bool result18 = Solution.IsMonotonic(Case18);
            bool result19 = Solution.IsMonotonic(Case19);
            bool result20 = Solution.IsMonotonic(Case20);
            bool result21 = Solution.IsMonotonic(Case21);
            bool result22 = Solution.IsMonotonic(Case22);
            bool result23 = Solution.IsMonotonic(Case23);
            bool result24 = Solution.IsMonotonic(Case24);
            bool result25 = Solution.IsMonotonic(Case25);
            bool result26 = Solution.IsMonotonic(Case26);
            bool result27 = Solution.IsMonotonic(Case27);
            bool result28 = Solution.IsMonotonic(Case28);
            bool result29 = Solution.IsMonotonic(Case29);
            bool result30 = Solution.IsMonotonic(Case30);
            bool result31 = Solution.IsMonotonic(Case31);
            bool result32 = Solution.IsMonotonic(Case32);
            bool result33 = Solution.IsMonotonic(Case33);
            bool result34 = Solution.IsMonotonic(Case34);
            bool result35 = Solution.IsMonotonic(Case35);
            bool result36 = Solution.IsMonotonic(Case36);
            bool result37 = Solution.IsMonotonic(Case37);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, result1),
                ResultTester.CheckResult<bool>(result2, result2),
                ResultTester.CheckResult<bool>(result3, result3),
                ResultTester.CheckResult<bool>(result4, result4),
                ResultTester.CheckResult<bool>(result5, result5),
                ResultTester.CheckResult<bool>(result6, result6),
                ResultTester.CheckResult<bool>(result7, result7),
                ResultTester.CheckResult<bool>(result8, result8),
                ResultTester.CheckResult<bool>(result9, result9),
                ResultTester.CheckResult<bool>(result10, result10),
                ResultTester.CheckResult<bool>(result11, result11),
                ResultTester.CheckResult<bool>(result12, result12),
                ResultTester.CheckResult<bool>(result13, result13),
                ResultTester.CheckResult<bool>(result14, result14),
                ResultTester.CheckResult<bool>(result15, result15),
                ResultTester.CheckResult<bool>(result16, result16),
                ResultTester.CheckResult<bool>(result17, result17),
                ResultTester.CheckResult<bool>(result18, result18),
                ResultTester.CheckResult<bool>(result19, result19),
                ResultTester.CheckResult<bool>(result20, result20),
                ResultTester.CheckResult<bool>(result21, result21),
                ResultTester.CheckResult<bool>(result22, result22),
                ResultTester.CheckResult<bool>(result23, result23),
                ResultTester.CheckResult<bool>(result24, result24),
                ResultTester.CheckResult<bool>(result25, result25),
                ResultTester.CheckResult<bool>(result26, result26),
                ResultTester.CheckResult<bool>(result27, result27),
                ResultTester.CheckResult<bool>(result28, result28),
                ResultTester.CheckResult<bool>(result29, result29),
                ResultTester.CheckResult<bool>(result30, result30),
                ResultTester.CheckResult<bool>(result31, result31),
                ResultTester.CheckResult<bool>(result32, result32),
                ResultTester.CheckResult<bool>(result33, result33),
                ResultTester.CheckResult<bool>(result34, result34),
                ResultTester.CheckResult<bool>(result35, result35),
                ResultTester.CheckResult<bool>(result36, result36),
                ResultTester.CheckResult<bool>(result37, result37),
            };
            return results;
        }
    }
}