// Remove Duplicates from Sorted Array

/*
Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int[] expectedNums = [...]; // The expected answer with correct length

int k = removeDuplicates(nums); // Calls your implementation

assert k == expectedNums.length;
for (int i = 0; i < k; i++) {
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.

 

Example 1:

Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Example 2:

Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveDuplicatesfromSortedArray
{
    public class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 1;

            foreach (int n in nums)
            {
                if (nums[i - 1] != n) nums[i++] = n;
            }

            return i;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,1,2};
            int[] nums2 = {0,0,1,1,1,2,2,3,3,4};
            int[] nums3 = { 1, 1, 1 };
            int[] nums4 = { 1, 2, 3 };
            int[] nums5 = {  };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.RemoveDuplicates(nums1), 2),
                ResultTester.CheckResult<int>(Solution.RemoveDuplicates(nums2), 5),
                ResultTester.CheckResult<int>(Solution.RemoveDuplicates(nums3), 1),
                ResultTester.CheckResult<int>(Solution.RemoveDuplicates(nums4), 3),
                ResultTester.CheckResult<int>(Solution.RemoveDuplicates(nums5), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}