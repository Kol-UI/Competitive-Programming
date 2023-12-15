// Non-overlapping Intervals

/*
Given an array of intervals intervals where intervals[i] = [starti, endi], return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.

 

Example 1:

Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.

Example 2:

Input: intervals = [[1,2],[1,2],[1,2]]
Output: 2
Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.

Example 3:

Input: intervals = [[1,2],[2,3]]
Output: 0
Explanation: You don't need to remove any of the intervals since they're already non-overlapping.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NonoverlappingIntervals
{
    public class Solution
    {
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            var n = intervals.Length;
            if (n == 1) return 0;

            var res = 0;
            Array.Sort(intervals, (a, b) => a[0] - b[0]);

            var end = Int32.MinValue;
            foreach (var interval in intervals)
            {
                if (interval[0] < end)
                {
                    res++;
                    end = Math.Min(interval[1], end);            
                }
                else
                {
                    end = interval[1];            
                }
            }

            return res;
        }
    }

    public class Test
    {
        public static bool[] TestNonoverlappingIntervals()
        {
            // Case 1
            int[][] intervals1_435 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 3 }
            };
            int result1_435 = Solution.EraseOverlapIntervals(intervals1_435);

            // Case 2
            int[][] intervals2_435 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 }
            };
            int result2_435 = Solution.EraseOverlapIntervals(intervals2_435);

            // Case 3
            int[][] intervals3_435 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            };
            int result3_435 = Solution.EraseOverlapIntervals(intervals3_435);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_435, 1),
                ResultTester.CheckResult<int>(result2_435, 2),
                ResultTester.CheckResult<int>(result3_435, 0)
            };
            return results;
        }
    }
}