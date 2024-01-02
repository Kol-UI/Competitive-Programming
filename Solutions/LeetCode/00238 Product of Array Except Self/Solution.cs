// Product of Array Except Self

/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ProductofArrayExceptSelf
{
    public class Solution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var arrLength = nums.Length;
            var output = new int[arrLength];
        
            for (int i = 0, prev = 1; i < arrLength; i++)
            {
                output[i] = prev;
                prev = nums[i] * prev;
            }
        
            for (int i = arrLength - 1, prev = 1; i >= 0; i--)
            {
                output[i] = output[i] * prev;
                prev = nums[i] * prev;
            }
            return output;
        }
    }

    public class Test
    {
        public static bool[] TestProductofArrayExceptSelf()
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
            int[] Case38 = { 1, 2, 3, 4 };
            int[] Case39 = { -1, 1, 0, -3, 3 };

            int[] result1 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case1);
            
            int[] result2 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case2);
            
            int[] result3 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case3);
            
            int[] result4 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case4);
            
            int[] result5 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case5);
            
            int[] result6 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case6);
            
            int[] result7 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case7);
            
            int[] result8 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case8);
            
            int[] result9 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case9);
            
            int[] result10 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case10);
            
            int[] result11 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case11);
            
            int[] result12 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case12);
            
            int[] result13 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case13);
            
            int[] result14 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case14);
            
            int[] result15 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case15);
            
            int[] result16 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case16);
            
            int[] result17 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case17);
            
            int[] result18 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case18);
            
            int[] result19 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case19);
            
            int[] result20 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case20);
            
            int[] result21 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case21);
            
            int[] result22 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case22);
            
            int[] result23 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case23);
            
            int[] result24 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case24);
            
            int[] result25 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case25);
            
            int[] result26 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case26);
            
            int[] result27 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case27);
            
            int[] result28 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case28);
            
            int[] result29 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case29);
            
            int[] result30 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case30);
            
            int[] result31 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case31);
            
            int[] result32 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case32);
            
            int[] result33 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case33);
            
            int[] result34 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case34);
            
            int[] result35 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case35);
            
            int[] result36 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case36);
            
            int[] result37 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case37);
            
            int[] result38 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case38);
            
            int[] result39 = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case39);
            

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, result1),
                ResultTester.CheckResult<int[]>(result2, result2),
                ResultTester.CheckResult<int[]>(result3, result3),
                ResultTester.CheckResult<int[]>(result4, result4),
                ResultTester.CheckResult<int[]>(result5, result5),
                ResultTester.CheckResult<int[]>(result6, result6),
                ResultTester.CheckResult<int[]>(result7, result7),
                ResultTester.CheckResult<int[]>(result8, result8),
                ResultTester.CheckResult<int[]>(result9, result9),
                ResultTester.CheckResult<int[]>(result10, result10),
                ResultTester.CheckResult<int[]>(result11, result11),
                ResultTester.CheckResult<int[]>(result12, result12),
                ResultTester.CheckResult<int[]>(result13, result13),
                ResultTester.CheckResult<int[]>(result14, result14),
                ResultTester.CheckResult<int[]>(result15, result15),
                ResultTester.CheckResult<int[]>(result16, result16),
                ResultTester.CheckResult<int[]>(result17, result17),
                ResultTester.CheckResult<int[]>(result18, result18),
                ResultTester.CheckResult<int[]>(result19, result19),
                ResultTester.CheckResult<int[]>(result20, result20),
                ResultTester.CheckResult<int[]>(result21, result21),
                ResultTester.CheckResult<int[]>(result22, result22),
                ResultTester.CheckResult<int[]>(result23, result23),
                ResultTester.CheckResult<int[]>(result24, result24),
                ResultTester.CheckResult<int[]>(result25, result25),
                ResultTester.CheckResult<int[]>(result26, result26),
                ResultTester.CheckResult<int[]>(result27, result27),
                ResultTester.CheckResult<int[]>(result28, result28),
                ResultTester.CheckResult<int[]>(result29, result29),
                ResultTester.CheckResult<int[]>(result30, result30),
                ResultTester.CheckResult<int[]>(result31, result31),
                ResultTester.CheckResult<int[]>(result32, result32),
                ResultTester.CheckResult<int[]>(result33, result33),
                ResultTester.CheckResult<int[]>(result34, result34),
                ResultTester.CheckResult<int[]>(result35, result35),
                ResultTester.CheckResult<int[]>(result36, result36),
                ResultTester.CheckResult<int[]>(result37, result37),
                ResultTester.CheckResult<int[]>(result38, result38),
                ResultTester.CheckResult<int[]>(result39, result39)
            };
            return results;
        }
    }
}