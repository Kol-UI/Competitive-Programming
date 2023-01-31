using System;
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
}

