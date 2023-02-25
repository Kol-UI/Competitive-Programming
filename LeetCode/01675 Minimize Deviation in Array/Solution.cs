using System;

namespace CompetitiveProgramming.LeetCode.MinimizeDeviationinArray
{
    // You are given an array nums of n positive integers.
    // You can perform two types of operations on any element of the array any number of times:
    // If the element is even, divide it by 2.
    // For example, if the array is [1,2,3,4], then you can do this operation on the last element, and the array will be [1,2,3,2].
    // If the element is odd, multiply it by 2.
    // For example, if the array is [1,2,3,4], then you can do this operation on the first element, and the array will be [2,2,3,4].
    // The deviation of the array is the maximum difference between any two elements in the array.
    // Return the minimum deviation the array can have after performing some number of operations.

    // Example 1:
    // Input: nums = [1,2,3,4]
    // Output: 1
    // Explanation: You can transform the array to [1,2,3,2], then to [2,2,3,2], then the deviation will be 3 - 2 = 1.
    
    // Example 2:
    // Input: nums = [4,1,5,20,3]
    // Output: 3
    // Explanation: You can transform the array after two operations to [4,2,5,5,3], then the deviation will be 5 - 2 = 3.
    
    // Example 3:
    // Input: nums = [2,10,8]
    // Output: 3

    public class Solution
    {
        // public int MinimumDeviation(int[] nums)
        // {
        //     int n = nums.Length;
        //     int[] minValues = new int[n], maxValues = new int[n];
        //     for (int i = 0; i < n; i++)
        //     {
        //         int y = nums[i];
        //         if (y % 2 == 1)
        //         {
        //             minValues[i] = y;
        //             maxValues[i] = 2 * y;
        //         }
        //         else
        //         {
        //             maxValues[i] = y;
        //             while (y % 2 == 0) y /= 2;
        //             minValues[i] = y;
        //         }
        //     }
        //     Array.Sort(minValues);
        //     LinkedList<int> vals = new LinkedList<int>(minValues);
        //     int maxMinValue = maxValues.Min();
        //     int smallestDifference = int.MaxValue; 
        //     var insertNode = vals.First;
        //     while (vals.First.Value <= maxMinValue)
        //     {
        //         smallestDifference = Math.Min(smallestDifference, vals.Last.Value - vals.First.Value);
        //         var first = vals.First;
        //         first.Value = 2 * first.Value;
        //         if (first.Value > first.Next.Value)
        //         {
        //             while (insertNode.Next != null && insertNode.Next.Value < first.Value)
        //                 insertNode = insertNode.Next;
        //             vals.AddAfter(insertNode, first.Value);
        //             vals.RemoveFirst();
        //         }
        //     }
        //     return smallestDifference;
        // }
    }
}