// Minimum Time Visiting All Points




using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTimeVisitingAllPoints
{
    public class Solution
    {
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            int totalTime = 0;
            
            for (int i = 0; i < points.Length - 1; i++)
            {
                int xDiff = Math.Abs(points[i + 1][0] - points[i][0]);
                int yDiff = Math.Abs(points[i + 1][1] - points[i][1]);
                
                totalTime += Math.Max(xDiff, yDiff);
            }
            
            return totalTime;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] points1 = new int[][]
            {
                new int[]{1,1},
                new int[]{3,4},
                new int[]{-1,0}
            };

            int[][] points2 = new int[][]
            {
                new int[]{3,2},
                new int[]{-2,2}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinTimeToVisitAllPoints(points1), 7),
                ResultTester.CheckResult<int>(Solution.MinTimeToVisitAllPoints(points2), 5),
            };
            return results;
        }
    }
}