// Merge Intervals

/*
Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

 

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MergeIntervals
{
    public class Solution
    {
        public static int[][] Merge(int[][] intervals) 
        {
            List<List<int>> result = new List<List<int>>();
            int resultcount = 0;
            
            List<List<int>> listintervals = intervals.Select(x => x.ToList()).ToList().OrderBy(x => x[0]).ToList();
            
            result.Add(listintervals[0]);
            
            for(int i = 1; i < listintervals.Count; i++)
            {
                if(result[resultcount][1] < listintervals[i][0])
                {
                    result.Add(listintervals[i]);
                    resultcount ++;
                }
                else 
                {
                    if(result[resultcount][0] > listintervals[i][0])
                    {
                        result[resultcount][0] = listintervals[i][0];
                    }
                    if(result[resultcount][1] < listintervals[i][1])
                    {
                        result[resultcount][1] = listintervals[i][1];
                    }
                    
                }
            }
            
            intervals = result.Select(x => x.ToArray()).ToArray();
            
            return intervals;
        }
    }

    public class Test
    {
        public static bool[] TestInsertInterval()
        {
            int[][] intervals1 = new int[][]
            {
                new int[] { 1,3 },
                new int[] { 2,6 },
                new int[] { 8,10 },
                new int[] { 15,18 }
            };

            int[][] intervals2 = new int[][]
            {
                new int[] { 1,4 },
                new int[] { 4,5 }
            };

            int[][] result1 = Solution.Merge(intervals1);
            int[][] result2 = Solution.Merge(intervals2);

            // Expected Matrix 1
            int[][] expected1 = new int[][]
            {
                new int[] {1, 6},
                new int[] {8, 10},
                new int[] {15, 18}
            };

            // Expected Matrix 2
            int[][] expected2 = new int[][]
            {
                new int[] {1, 5}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(result1, expected1),
                ResultTester.CheckResult<int[][]>(result2, expected2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestInsertInterval());
        }
    }
}