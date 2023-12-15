// Number of Provinces

/*
There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b, and city b is connected directly with city c, then city a is connected indirectly with city c.

A province is a group of directly or indirectly connected cities and no other cities outside of the group.

You are given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and isConnected[i][j] = 0 otherwise.

Return the total number of provinces.

 

Example 1:


Input: isConnected = [[1,1,0],[1,1,0],[0,0,1]]
Output: 2


Example 2:


Input: isConnected = [[1,0,0],[0,1,0],[0,0,1]]
Output: 3
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofProvinces
{
    public class Solution
    {
        public static int FindCircleNum(int[][] isConnected)
        {
            int n = isConnected.Length;
            bool[] visited = new bool[n];
            int provinces = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    provinces++;
                    DFS(isConnected, visited, i, n);
                }
            }
            
            return provinces;
        }
        
        private static void DFS(int[][] isConnected, bool[] visited, int i, int n)
        {
            visited[i] = true;
            for (int j = 0; j < n; j++)
            {
                if (isConnected[i][j] == 1 && !visited[j])
                {
                    DFS(isConnected, visited, j, n);
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestNumberofProvinces()
        {
            // Case 1
            int[][] case1_547 = new int[][]
            {
                new int[] { 1,1,0 },
                new int[] { 1,1,0 },
                new int[] { 0,0,1 }
            };
            int result1 = LeetCode.NumberofProvinces.Solution.FindCircleNum(case1_547);
            
            // Case 2
            int[][] case2_547 = new int[][]
            {
                new int[] { 1,0,0 },
                new int[] { 0,1,0 },
                new int[] { 0,0,1 }
            };
            int result2 = LeetCode.NumberofProvinces.Solution.FindCircleNum(case2_547);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 3)
            };
            return results;
        }
    }
}