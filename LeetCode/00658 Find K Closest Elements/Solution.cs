// Find K Closest Elements

/*
Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array. The result should also be sorted in ascending order.

An integer a is closer to x than an integer b if:

|a - x| < |b - x|, or
|a - x| == |b - x| and a < b
 

Example 1:

Input: arr = [1,2,3,4,5], k = 4, x = 3
Output: [1,2,3,4]

Example 2:

Input: arr = [1,2,3,4,5], k = 4, x = -1
Output: [1,2,3,4]
*/

using System;
namespace CompetitiveProgramming.LeetCode.FindKClosestElements
{
    public class Solution 
    {
        public static IList<int> FindClosestElements(int[] arr, int k, int x) 
        {
            int start = 0, end = arr.Length - 1;

            while (end - start >= k)
            {
                if (Math.Abs(x - arr[end]) < Math.Abs(x - arr[start]))
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            
            int[] ret = new int[k];
            Array.Copy(arr, start, ret, 0, k);
                
            return ret.ToList();
        }
    }
}