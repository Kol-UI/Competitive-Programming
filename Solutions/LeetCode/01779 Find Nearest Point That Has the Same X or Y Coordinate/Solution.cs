// Find Nearest Point That Has the Same X or Y Coordinate

/*
You are given two integers, x and y, which represent your current location on a Cartesian grid: (x, y). You are also given an array points where each points[i] = [ai, bi] represents that a point exists at (ai, bi). A point is valid if it shares the same x-coordinate or the same y-coordinate as your location.

Return the index (0-indexed) of the valid point with the smallest Manhattan distance from your current location. If there are multiple, return the valid point with the smallest index. If there are no valid points, return -1.

The Manhattan distance between two points (x1, y1) and (x2, y2) is abs(x1 - x2) + abs(y1 - y2).

 

Example 1:

Input: x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]]
Output: 2
Explanation: Of all the points, only [3,1], [2,4] and [4,4] are valid. Of the valid points, [2,4] and [4,4] have the smallest Manhattan distance from your current location, with a distance of 1. [2,4] has the smallest index, so return 2.

Example 2:

Input: x = 3, y = 4, points = [[3,4]]
Output: 0
Explanation: The answer is allowed to be on the same location as your current location.

Example 3:

Input: x = 3, y = 4, points = [[2,3]]
Output: -1
Explanation: There are no valid points.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindNearestPointThatHastheSameXorYCoordinate
{
    public class Solution
    {
        public static int NearestValidPoint(int x, int y, int[][] points)
        {
            int shortestIndex = -1;
            int shortestDistance = -1;
            
            for(int i = 0; i < points.Length; i++)
            {
                var point = points[i];
                if (point.Length != 2 || !(point[0] == x || point[1] == y)) continue;
                
                int distance = Math.Abs(x - point[0]) + Math.Abs(y - point[1]);

                if(shortestIndex == -1 || distance < shortestDistance)
                {
                    shortestIndex = i;
                    shortestDistance = distance;
                }
            }
            return shortestIndex;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] points1 = new int[][]
            {
                new int[] { 1,2 },
                new int[] { 3,1 },
                new int[] { 2,4 },
                new int[] { 2,3 },
                new int[] { 4,4 }
            };

            int[][] points2 = new int[][]
            {
                new int[] { 3,4 }
            };

            int[][] points3 = new int[][]
            {
                new int[] { 2,3 }
            };

            int result1 = Solution.NearestValidPoint(3, 4, points1);
            int result2 = Solution.NearestValidPoint(3, 4, points2);
            int result3 = Solution.NearestValidPoint(3, 4, points3);
            
            int output1 = 2;
            int output2 = 0;
            int output3 = -1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1),
                ResultTester.CheckResult<int>(result2, output2),
                ResultTester.CheckResult<int>(result3, output3)
            };
            return results;
        }
    }
}