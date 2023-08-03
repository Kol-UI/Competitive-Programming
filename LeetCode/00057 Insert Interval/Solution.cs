using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.InsertInterval
{
    public class Solution
	{
        //You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti.You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

        //Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

        //Return intervals after the insertion.

        //Example 1:
        //Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
        //Output: [[1,5],[6,9]]
        //Example 2:
        //Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
        //Output: [[1,2],[3,10],[12,16]]
        //Explanation: Because the new interval[4, 8] overlaps with[3, 5],[6,7],[8,10].

        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (newInterval == null)
            {
                return intervals;
            }
            else
            {
                var list = new List<int[]>();
                foreach (var value in intervals)
                {
                    if (value[0] > newInterval[1])
                    {
                        list.Add(newInterval);
                        newInterval = value;
                    }
                    else if (value[1] < newInterval[0])
                    {
                        list.Add(value);
                    }
                    else
                    {
                        newInterval[0] = Math.Min(newInterval[0], value[0]);
                        newInterval[1] = Math.Max(newInterval[1], value[1]);
                    }
                }
                list.Add(newInterval);
                return list.ToArray();
            }
        }

    }

    public class Test
    {
        public static bool[] TestInsertInterval()
        {
            // Case 1
            int[][] intervalsCase1_57 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 }
            };
            int[] newIntervalsCase1_57 = { 2, 5 };
            int[][] Case1_57_Result = Solution.Insert(intervalsCase1_57, newIntervalsCase1_57);

            // Case 2
            int[][] intervalsCase2_57 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 7 },
                new int[] { 8, 10 },
                new int[] { 12, 16 }
            };
            int[] newIntervalsCase2_57 = { 4, 8 };
            int[][] Case2_57_Result = Solution.Insert(intervalsCase2_57, newIntervalsCase2_57);

            // Expected Matrix 1
            int[][] expected1 = new int[][]
            {
                new int[] {1, 5},
                new int[] {6, 9}
            };

            // Expected Matrix 2
            int[][] expected2 = new int[][]
            {
                new int[] {1, 2},
                new int[] {3, 10},
                new int[] {12, 16}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Case1_57_Result, expected1),
                ResultTester.CheckResult<int[][]>(Case2_57_Result, expected2),
            };
            return results;
        }
    }
}

