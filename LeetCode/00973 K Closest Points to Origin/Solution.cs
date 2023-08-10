// K Closest Points to Origin

/*
Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and an integer k, return the k closest points to the origin (0, 0).

The distance between two points on the X-Y plane is the Euclidean distance (i.e., √(x1 - x2)2 + (y1 - y2)2).

You may return the answer in any order. The answer is guaranteed to be unique (except for the order that it is in).

 

Example 1:


Input: points = [[1,3],[-2,2]], k = 1
Output: [[-2,2]]
Explanation:
The distance between (1, 3) and the origin is sqrt(10).
The distance between (-2, 2) and the origin is sqrt(8).
Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
We only want the closest k = 1 points from the origin, so the answer is just [[-2,2]].


Example 2:

Input: points = [[3,3],[5,-1],[-2,4]], k = 2
Output: [[3,3],[-2,4]]
Explanation: The answer [[-2,4],[3,3]] would also be accepted.
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KClosestPointstoOrigin
{
    public class Solution
    {
        public static int[][] KClosest(int[][] points, int k) 
        {
            Dictionary<int[], double> map = new();

            foreach (int[] point in points)
            {
                if (!map.ContainsKey(point))
                {
                    map.Add(point, Math.Sqrt(point[0] * point[0] + point[1] * point[1]));
                }
            }

            var sorted = from item in map orderby item.Value ascending select item;

            int[][] r = new int[k][];

            int c = 0;

            foreach (var pair in sorted)
            {
                if (c == k) return r;

                r[c] = pair.Key;

                c++;
            }

            return r;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] points1 = new int[][]
            {
                new int[] {1, 3},
                new int[] {-2, 2}
            };

            int[][] points2 = new int[][]
            {
                new int[] {3, 3},
                new int[] {5, -1},
                new int[] {-2, 4}
            };

            int[][] expected1 = new int[][]
            {
                new int[] {-2, 2}
            };

            int[][] expected2 = new int[][]
            {
                new int[] {3, 3},
                new int[] {-2, 4}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.KClosest(points1, 1), expected1),
                ResultTester.CheckResult<int[][]>(Solution.KClosest(points2, 2), expected2),
            };

            return results;
        }
    }
}