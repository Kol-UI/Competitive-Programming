// Next Permutation

/*
A permutation of an array of integers is an arrangement of its members into a sequence or linear order.

For example, for arr = [1,2,3], the following are all the permutations of arr: [1,2,3], [1,3,2], [2, 1, 3], [2, 3, 1], [3,1,2], [3,2,1].
The next permutation of an array of integers is the next lexicographically greater permutation of its integer. More formally, if all the permutations of the array are sorted in one container according to their lexicographical order, then the next permutation of that array is the permutation that follows it in the sorted container. If such arrangement is not possible, the array must be rearranged as the lowest possible order (i.e., sorted in ascending order).

For example, the next permutation of arr = [1,2,3] is [1,3,2].
Similarly, the next permutation of arr = [2,3,1] is [3,1,2].
While the next permutation of arr = [3,2,1] is [1,2,3] because [3,2,1] does not have a lexicographical larger rearrangement.
Given an array of integers nums, find the next permutation of nums.

The replacement must be in place and use only constant extra memory.

 

Example 1:

Input: nums = [1,2,3]
Output: [1,3,2]

Example 2:

Input: nums = [3,2,1]
Output: [1,2,3]

Example 3:

Input: nums = [1,1,5]
Output: [1,5,1]
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NextPermutation
{
    public class Solution
    {
        public static void NextPermutation(int[] nums)
        {
            for(int i = nums.Length - 1; i > 0; i--)
            {
                if(nums[i-1] < nums[i])
                {
                    for(int j = nums.Length - 1; j >= 0; j--)
                    {
                        // Search for first greater int
                        if(nums[j] > nums[i-1])
                        {
                            Swap(nums, i-1, j);
                            Array.Reverse(nums, i, (nums.Length)-i);
                            PrintHelper.PrintArray(nums); // For Test
                            return;
                        }
                    }
                }
            }

            Array.Reverse(nums);
            PrintHelper.PrintArray(nums); // For Test
        }
        
        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }

    public class Test
    {
        public static bool[] TestNextPermutation()
        {
            int[] case1 = { 1, 2, 3 };
            int[] case2 = { 3, 2, 1 };
            int[] case3 = { 1, 1, 5 };

            Solution.NextPermutation(case1);
            Solution.NextPermutation(case2);
            Solution.NextPermutation(case3);

            bool[] results = new bool[]
            {
                true, true, true
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Permutation");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestNextPermutation());
        }
    }
}