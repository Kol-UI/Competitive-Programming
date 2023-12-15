// Median of Two Sorted Arrays

/*
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MedianofTwoSortedArrays
{
    public class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> merged = new List<int>();
            int i = 0, j = 0;
            
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    merged.Add(nums1[i++]);
                }
                else
                {
                    merged.Add(nums2[j++]);
                }
            }
            
            while (i < nums1.Length) merged.Add(nums1[i++]);
            while (j < nums2.Length) merged.Add(nums2[j++]);
            
            int mid = merged.Count / 2;
            if (merged.Count % 2 == 0)
            {
                return (merged[mid-1] + merged[mid]) / 2.0;
            }
            else
            {
                return merged[mid];
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1 = {1,3};
            int[] nums2_1 = {2};
            int[] nums1_2 = {1,2};
            int[] nums2_2 = {3,4};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(Solution.FindMedianSortedArrays(nums1_1, nums2_1), 2.00000),
                ResultTester.CheckResult<double>(Solution.FindMedianSortedArrays(nums1_2, nums2_2), 2.50000),
            };
            return results;
        }
    }
}