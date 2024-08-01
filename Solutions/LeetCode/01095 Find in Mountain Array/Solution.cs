// Find in Mountain Array

/*
(This problem is an interactive problem.)

You may recall that an array arr is a mountain array if and only if:

arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Given a mountain array mountainArr, return the minimum index such that mountainArr.get(index) == target. If such an index does not exist, return -1.

You cannot access the mountain array directly. You may only access the array using a MountainArray interface:

MountainArray.get(k) returns the element of the array at index k (0-indexed).
MountainArray.length() returns the length of the array.
Submissions making more than 100 calls to MountainArray.get will be judged Wrong Answer. Also, any solutions that attempt to circumvent the judge will result in disqualification.

 

Example 1:

Input: array = [1,2,3,4,5,3,1], target = 3
Output: 2
Explanation: 3 exists in the array, at index=2 and index=5. Return the minimum index, which is 2.

Example 2:

Input: array = [0,1,2,4,2,1], target = 3
Output: -1
Explanation: 3 does not exist in the array, so we return -1.

*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindinMountainArray
{
    /**
    * // This is MountainArray's API interface.
    * // You should not implement it, or speculate about its implementation
    * class MountainArray {
    *     public int Get(int index) {}
    *     public int Length() {}
    * }
    */

/*
    class Solution
    {
        public int FindInMountainArray(int target, MountainArray mountainArr)
        {
            int peakIndex = FindPeakIndex(mountainArr);
            
            int leftIndex = BinarySearch(mountainArr, target, 0, peakIndex, true);
            if (leftIndex != -1)
                return leftIndex;
            
            int rightIndex = BinarySearch(mountainArr, target, peakIndex + 1, mountainArr.Length() - 1, false);
            return rightIndex;
        }
        
        private int FindPeakIndex(MountainArray mountainArr)
        {
            int left = 0;
            int right = mountainArr.Length() - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                    left = mid + 1;
                else
                    right = mid;
            }
            
            return left;
        }
        
        private int BinarySearch(MountainArray mountainArr, int target, int left, int right, bool ascending)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = mountainArr.Get(mid);
                
                if (midValue == target)
                    return mid;
                
                if (ascending)
                {
                    if (midValue < target)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                else
                {
                    if (midValue > target)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }
            
            return -1;
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find in Mountain Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}