// Find Right Interval

/*
You are given an array of intervals, where intervals[i] = [starti, endi] and each starti is unique.

The right interval for an interval i is an interval j such that startj >= endi and startj is minimized. Note that i may equal j.

Return an array of right interval indices for each interval i. If no right interval exists for interval i, then put -1 at index i.

 

Example 1:

Input: intervals = [[1,2]]
Output: [-1]
Explanation: There is only one interval in the collection, so it outputs -1.

Example 2:

Input: intervals = [[3,4],[2,3],[1,2]]
Output: [-1,0,1]
Explanation: There is no right interval for [3,4].
The right interval for [2,3] is [3,4] since start0 = 3 is the smallest start that is >= end1 = 3.
The right interval for [1,2] is [2,3] since start1 = 2 is the smallest start that is >= end2 = 2.

Example 3:

Input: intervals = [[1,4],[2,3],[3,4]]
Output: [-1,2,-1]
Explanation: There is no right interval for [1,4] and [3,4].
The right interval for [2,3] is [3,4] since start2 = 3 is the smallest start that is >= end1 = 3.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindRightInterval
{
    public class Solution 
    {
        public static int[] FindRightInterval(int[][] intervals)
        {
            var n = intervals.Length;
            var result = new int[n];
            var starts = new int[n][];

            for (var i = 0; i < n; i++)
                starts[i] = new int[2] {intervals[i][0], i};

            Array.Sort(starts, (a, b) => a[0] - b[0]);

            for (var i = 0; i < n; i++)
            {
                if (intervals[i][0] == intervals[i][1])
                {
                    result[i] = i;
                    continue;
                }

                var target = intervals[i][1];
                var left = 0;
                var right = n - 1;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;
                    
                    if (starts[mid][0] >= target)
                        right = mid;
                    else
                        left = mid + 1;
                }

                result[i] = (i != starts[right][1] && starts[right][0] >= target) ? starts[right][1] : -1;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestFindRightInterval()
        {
            int[][] intervals1 = new int[][]
            {
                new int[] { 1, 2 }
            };
            int[][] intervals2 = new int[][]
            {
                new int[] { 3, 4 },
                new int[] { 2, 3 },
                new int[] { 1, 2 }
            };
            int[][] intervals3 = new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 3, 4 }
            };

            int[] result1 = Solution.FindRightInterval(intervals1);
            int[] result2 = Solution.FindRightInterval(intervals2);
            int[] result3 = Solution.FindRightInterval(intervals3);

            int[] expected1 = {-1};
            int[] expected2 = {-1,0,1};
            int[] expected3 = {-1,2,-1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2),
                ResultTester.CheckResult<int[]>(result3, expected3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Right Interval");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestFindRightInterval());
        }
    }
}