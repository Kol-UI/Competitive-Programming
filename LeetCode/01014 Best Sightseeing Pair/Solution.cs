// Best Sightseeing Pair

/*
You are given an integer array values where values[i] represents the value of the ith sightseeing spot. Two sightseeing spots i and j have a distance j - i between them.

The score of a pair (i < j) of sightseeing spots is values[i] + values[j] + i - j: the sum of the values of the sightseeing spots, minus the distance between them.

Return the maximum score of a pair of sightseeing spots.


Example 1:

Input: values = [8,1,5,2,6]
Output: 11
Explanation: i = 0, j = 2, values[i] + values[j] + i - j = 8 + 5 + 0 - 2 = 11

Example 2:

Input: values = [1,2]
Output: 2
*/

using System;
namespace CompetitiveProgramming.LeetCode.BestSightseeingPair
{
    public class Solution
    {
        public static int MaxScoreSightseeingPair(int[] values)
        {
            var rs = values[values.Length - 1] + values[values.Length - 2] - 1;
            var prev = rs;
            
            for (int i = values.Length - 3; i >= 0; i--)
            {
                var next0 = prev - 1 + (values[i] - values[i + 1]);
                var next1 = values[i] + values[i + 1] - 1;
                prev = Math.Max(next0, next1);
                if (rs < prev) rs = prev;
            }
            return rs;
        }
    }
}