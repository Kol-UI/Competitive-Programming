// Next Greater Element III

/*
Given a positive integer n, find the smallest integer which has exactly the same digits existing in the integer n and is greater in value than n. If no such positive integer exists, return -1.

Note that the returned integer should fit in 32-bit integer, if there is a valid answer but it does not fit in 32-bit integer, return -1.

 

Example 1:

Input: n = 12
Output: 21

Example 2:

Input: n = 21
Output: -1

*/

using System;
namespace CompetitiveProgramming.LeetCode.NextGreaterElementIII
{
    public class Solution
    {
        public static int NextGreaterElement(int n)
        {
            var arr = ($"{n}").ToArray();
            var l = arr.Length;
            
            for(int i = 1; i < l; i++)
            {
                for(int j = l - 1; j - i >= 0; j--)
                {
                    if(arr[j] > arr[j-i])
                    {
                        var sub = arr.Skip(j - i).Take(l - j + i).OrderBy(p => p).ToList();
                        var mid = sub.Where(p => p > arr[j - i]).FirstOrDefault();
                        sub.Remove(mid);
                        arr = arr.Take(j - i).ToArray();
                        var str = $"{new string(arr)}{mid}{new string(sub.ToArray())}";
                        return Int32.TryParse(str, out int result)? result: - 1;
                    }
                }
            }
            return -1;
        }
    }
}