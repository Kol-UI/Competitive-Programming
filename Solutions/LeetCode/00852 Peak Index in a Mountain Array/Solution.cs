// Peak Index in a Mountain Array

/*
An array arr a mountain if the following properties hold:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i] 
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Given a mountain array arr, return the index i such that arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

You must solve it in O(log(arr.length)) time complexity.

 

Example 1:

Input: arr = [0,1,0]
Output: 1

Example 2:

Input: arr = [0,2,1,0]
Output: 1

Example 3:

Input: arr = [0,10,5,2]
Output: 1
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PeakIndexinaMountainArray
{
    public class Solution
    {
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;

            while(i < j)
            {
                int mid = i + (j - i) / 2;

                if(arr[mid] < arr[mid + 1]) i = mid + 1;
                
                else j = mid;
            }
            
            return j;
        }
    }

    public class Test
    {
        public static bool[] TestPeakIndexinaMountainArray()
        {
            int[] arr1 = { 0,1,0 };
            int[] arr2 = { 0,2,1,0 };
            int[] arr3 = { 0,10,5,2 };

            int result1 = Solution.PeakIndexInMountainArray(arr1);
            int result2 = Solution.PeakIndexInMountainArray(arr2);
            int result3 = Solution.PeakIndexInMountainArray(arr3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, 1)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Peak Index in a Mountain Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestPeakIndexinaMountainArray());
        }
    }
}