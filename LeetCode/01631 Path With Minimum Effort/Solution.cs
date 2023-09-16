// Path With Minimum Effort

/*
You are a hiker preparing for an upcoming hike. You are given heights, a 2D array of size rows x columns, where heights[row][col] represents the height of cell (row, col). You are situated in the top-left cell, (0, 0), and you hope to travel to the bottom-right cell, (rows-1, columns-1) (i.e., 0-indexed). You can move up, down, left, or right, and you wish to find a route that requires the minimum effort.

A route's effort is the maximum absolute difference in heights between two consecutive cells of the route.

Return the minimum effort required to travel from the top-left cell to the bottom-right cell.

 

Example 1:



Input: heights = [[1,2,2],[3,8,2],[5,3,5]]
Output: 2
Explanation: The route of [1,3,5,3,5] has a maximum absolute difference of 2 in consecutive cells.
This is better than the route of [1,2,2,2,5], where the maximum absolute difference is 3.


Example 2:



Input: heights = [[1,2,3],[3,8,4],[5,3,5]]
Output: 1
Explanation: The route of [1,2,3,4,5] has a maximum absolute difference of 1 in consecutive cells, which is better than route [1,3,5,3,5].


Example 3:


Input: heights = [[1,2,1,1,1],[1,2,1,2,1],[1,2,1,2,1],[1,2,1,2,1],[1,1,1,2,1]]
Output: 0
Explanation: This route does not require any effort.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PathWithMinimumEffort
{
    public class Solution 
    {
        public static int MinimumEffortPath(int[][] heights) 
        {
            int m = heights.Length;
            int n = heights[0].Length;
            
            int[,] minDisArr = new int[m,n];
            
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    minDisArr[i,j] = int.MaxValue;
                }
            }
            
            minDisArr[0,0] = 0;
            
            PriorityQueue<(int x, int y),int> priorityQueue = new();
            priorityQueue.Enqueue((0,0),0);
            
            
            int[] dX = {-1,1,0,0};
            int[] dY = {0,0,-1,1};
            
            while(priorityQueue.Count>0)
            {
                var current = priorityQueue.Dequeue();
                
                if(current.x == m - 1 && current.y == n - 1)
                    break;
                
                for(int d = 0; d < 4; d++)
                {
                    int a = current.x + dX[d];
                    int b = current.y + dY[d];
                    
                    if(a < 0 || a >= m || b < 0 || b >= n)
                        continue;
                    
                    int wt = Math.Max(minDisArr[current.x,current.y],Math.Abs(heights[a][b] - heights[current.x][current.y]));
                    
                    if(minDisArr[a,b] > wt)
                    {
                        minDisArr[a,b] = wt;
                        priorityQueue.Enqueue((a,b), wt);
                    }
                }
            }
            
            return minDisArr[m-1,n-1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] heights1 = new int[][]
            {
                new int[] { 1, 2, 2 },
                new int[] { 3, 8, 2 },
                new int[] { 5, 3, 5 }
            };

            int[][] heights2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 3, 8, 4 },
                new int[] { 5, 3, 5 }
            };

            int[][] heights3 = new int[][]
            {
                new int[] { 1, 2, 1, 1, 1 },
                new int[] { 1, 2, 1, 2, 1 },
                new int[] { 1, 2, 1, 2, 1 },
                new int[] { 1, 2, 1, 2, 1 },
                new int[] { 1, 1, 1, 2, 1 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumEffortPath(heights1), 2),
                ResultTester.CheckResult<int>(Solution.MinimumEffortPath(heights2), 1),
                ResultTester.CheckResult<int>(Solution.MinimumEffortPath(heights3), 0),
            };
            return results;
        }
    }
}