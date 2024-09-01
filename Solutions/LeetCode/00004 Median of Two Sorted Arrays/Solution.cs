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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
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

    public class Solution2
    {
        private static List<int> SortList(List<int> numbers)
        {
            numbers.Sort();
            return numbers;
        }

        private static double FindMedian(List<int> sortedNumbers)
        {
            int count = sortedNumbers.Count;

            if (count == 0)
            {
                throw new InvalidOperationException("Cannot find median of an empty list.");
            }

            if (IsOddOrEven(count))
            {
                return GetMiddleElementInEvenList(sortedNumbers);
            }
            else
            {
                int mid1 = sortedNumbers[(count / 2) - 1];
                int mid2 = sortedNumbers[count / 2];
                return GetAverage(new List<int> { mid1, mid2 });
            }
        }

        private static bool IsOddOrEven(int value)
        {
            if (value % 2 == 1)
                return true;
            else
                return false;
        }

        private static int GetMiddleElementInEvenList(List<int> list)
        {
            return list[list.Count / 2];
        }

        private static double GetAverage(List<int> ints)
        {
            int sum = 0;
            foreach (int number in ints)
            {
                sum += number;
            }
            return (double)sum / ints.Count;
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

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Median of Two Sorted Arrays");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}