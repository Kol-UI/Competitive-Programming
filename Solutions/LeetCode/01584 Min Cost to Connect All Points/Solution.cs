// Min Cost to Connect All Points

/*
You are given an array points representing integer coordinates of some points on a 2D-plane, where points[i] = [xi, yi].

The cost of connecting two points [xi, yi] and [xj, yj] is the manhattan distance between them: |xi - xj| + |yi - yj|, where |val| denotes the absolute value of val.

Return the minimum cost to make all points connected. All points are connected if there is exactly one simple path between any two points.

 

Example 1:


Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
Output: 20
Explanation: 

We can connect the points as shown above to get the minimum cost of 20.
Notice that there is a unique path between every pair of points.


Example 2:

Input: points = [[3,12],[-2,5],[-4,1]]
Output: 18
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinCosttoConnectAllPoints
{
    public class Solution
    {
        public static int MinCostConnectPoints(int[][] points)
        {
            var visited = new HashSet<int[]>();
            var queue = new PriorityQueue<int[], int>();
            var totalCost = 0;

            queue.Enqueue(points[0], 0);
            while (visited.Count < points.Length && queue.TryDequeue(out int[]? next, out int cost))
                if (!visited.Contains(next))
                {
                    totalCost += cost;
                    visited.Add(next);

                    foreach (var point in points)
                        if (!visited.Contains(point))
                            queue.Enqueue(point, Math.Abs(point[0] - next[0]) + Math.Abs(point[1] - next[1]));
                }

            return totalCost;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] points1 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 2, 2 },
                new int[] { 3, 10 },
                new int[] { 5, 2 },
                new int[] { 7, 0 }
            };

            int[][] points2 = new int[][]
            {
                new int[] { 3, 12 },
                new int[] { -2, 5 },
                new int[] { -4, 1 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinCostConnectPoints(points1), 20),
                ResultTester.CheckResult<int>(Solution.MinCostConnectPoints(points2), 18),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Min Cost to Connect All Points");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}