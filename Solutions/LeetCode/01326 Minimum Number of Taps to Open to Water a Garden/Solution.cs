// Minimum Number of Taps to Open to Water a Garden

/*
There is a one-dimensional garden on the x-axis. The garden starts at the point 0 and ends at the point n. (i.e., the length of the garden is n).

There are n + 1 taps located at points [0, 1, ..., n] in the garden.

Given an integer n and an integer array ranges of length n + 1 where ranges[i] (0-indexed) means the i-th tap can water the area [i - ranges[i], i + ranges[i]] if it was open.

Return the minimum number of taps that should be open to water the whole garden, If the garden cannot be watered return -1.

 

Example 1:


Input: n = 5, ranges = [3,4,1,1,0,0]
Output: 1
Explanation: The tap at point 0 can cover the interval [-3,3]
The tap at point 1 can cover the interval [-3,5]
The tap at point 2 can cover the interval [1,3]
The tap at point 3 can cover the interval [2,4]
The tap at point 4 can cover the interval [4,4]
The tap at point 5 can cover the interval [5,5]
Opening Only the second tap will water the whole garden [0,5]
Example 2:

Input: n = 3, ranges = [0,0,0,0]
Output: -1
Explanation: Even if you activate all the four taps you cannot water the whole garden.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofTapstoOpentoWateraGarden
{
    public class Solution
    {
        public static int MinTaps(int n, int[] ranges)
        {
            PriorityQueue<int[],int> pq = new(Comparer<int>.Create((a, b) => a.CompareTo(b)));

            for(int i = 0; i < ranges.Length;i++)
            {
                int start = Math.Max(0, i - ranges[i]);
                int end = Math.Min(n, i + ranges[i]);

                if(start < end)
                {
                    pq.Enqueue(new int[]{start,end}, start);
                }
            }

            int covered = 0;
            int result = 0;

            while(pq.Count > 0 && covered < n)
            { 
                int end = 0;

                while(pq.Count > 0 && pq.Peek()[0] <= covered)
                {
                    end = Math.Max(end,pq.Dequeue()[1]);
                }
                result++;

                if(end == covered)
                {
                    return -1;
                }
                covered = end;
            }

            if(covered == n)
            {
                return result;
            }

            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 5;
            int[] ranges1 = {3,4,1,1,0,0};
            int n2 = 3;
            int[] ranges2 = {0,0,0,0};
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinTaps(n1, ranges1), 1),
                ResultTester.CheckResult<int>(Solution.MinTaps(n2, ranges2), -1),
            };
            return results;
        }
    }
}