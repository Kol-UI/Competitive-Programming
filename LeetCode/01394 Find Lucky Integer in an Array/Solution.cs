using System;
namespace CompetitiveProgramming.LeetCode.FindLuckyIntegerinanArray
{
	public class Solution
    {
        // Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
        // Return the largest lucky integer in the array. If there is no lucky integer return -1.

        // Example 1:

        // Input: arr = [2,2,3,4]
        // Output: 2
        // Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        
        // Example 2:

        // Input: arr = [1,2,2,3,3,3]
        // Output: 3
        // Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
        
        // Example 3:

        // Input: arr = [2,2,2,3,3]
        // Output: -1
        // Explanation: There are no lucky numbers in the array.

        public static int FindLucky(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else map.Add(arr[i], 1);
            }
            var lucky = map.Where(x => x.Key == x.Value);

            return lucky.Count() > 0 ? lucky.Max(x=>x.Value) : -1;
        }

    }
}