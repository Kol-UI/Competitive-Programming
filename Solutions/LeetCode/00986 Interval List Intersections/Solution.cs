// Interval List Intersections

/*
You are given two lists of closed intervals, firstList and secondList, where firstList[i] = [starti, endi] and secondList[j] = [startj, endj]. Each list of intervals is pairwise disjoint and in sorted order.

Return the intersection of these two interval lists.

A closed interval [a, b] (with a <= b) denotes the set of real numbers x with a <= x <= b.

The intersection of two closed intervals is a set of real numbers that are either empty or represented as a closed interval. For example, the intersection of [1, 3] and [2, 4] is [2, 3].

 

Example 1:

Input: firstList = [[0,2],[5,10],[13,23],[24,25]], secondList = [[1,5],[8,12],[15,24],[25,26]]
Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]

Example 2:

Input: firstList = [[1,3],[5,9]], secondList = []
Output: []
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IntervalListIntersections
{
    public class Solution
    {
        public static int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            int i = 0;
            int j = 0;
            int n = firstList.Length;
            int m = secondList.Length;
            List<int[]> result = new List<int[]>();

            while(i < n && j < m)
            {
                var l = Math.Max(firstList[i][0],secondList[j][0]);
                var r = Math.Min(firstList[i][1],secondList[j][1]);

                if(l <= r)
                {
                    result.Add(new int[2]{l, r});
                }

                if(firstList[i][1] <= secondList[j][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestIntervalListIntersections()
        {
            int[][] firstList = new int[][]
            {
                new int[] {0, 2},
                new int[] {5, 10},
                new int[] {13, 23},
                new int[] {24, 25}
            };

            int[][] secondList = new int[][]
            {
                new int[] {1, 5},
                new int[] {8, 12},
                new int[] {15, 24},
                new int[] {25, 26}
            };

            int[][] expectedOutput = new int[][]
            {
                new int[] {1, 2},
                new int[] {5, 5},
                new int[] {8, 10},
                new int[] {15, 23},
                new int[] {24, 24},
                new int[] {25, 25}
            };

            int[][] firstList2 = new int[][]
            {
                new int[] {1, 3},
                new int[] {5, 9}
            };

            int[][] secondList2 = new int[][] { };

            int[][] expectedOutput2 = new int[][] { };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.IntervalIntersection(firstList, secondList), expectedOutput),
                ResultTester.CheckResult<int[][]>(Solution.IntervalIntersection(firstList2, secondList2), expectedOutput2)
            };

            return results;
        }
    }
}