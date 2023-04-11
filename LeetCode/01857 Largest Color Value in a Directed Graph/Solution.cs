// Largest Color Value in a Directed Graph

/*
There is a directed graph of n colored nodes and m edges. The nodes are numbered from 0 to n - 1.

You are given a string colors where colors[i] is a lowercase English letter representing the color of the ith node in this graph (0-indexed). You are also given a 2D array edges where edges[j] = [aj, bj] indicates that there is a directed edge from node aj to node bj.

A valid path in the graph is a sequence of nodes x1 -> x2 -> x3 -> ... -> xk such that there is a directed edge from xi to xi+1 for every 1 <= i < k. The color value of the path is the number of nodes that are colored the most frequently occurring color along that path.

Return the largest color value of any valid path in the given graph, or -1 if the graph contains a cycle.

 

Example 1:
Input: colors = "abaca", edges = [[0,1],[0,2],[2,3],[3,4]]
Output: 3
Explanation: The path 0 -> 2 -> 3 -> 4 contains 3 nodes that are colored "a" (red in the above image).
Example 2:
Input: colors = "a", edges = [[0,0]]
Output: -1
Explanation: There is a cycle from 0 to 0.
*/

using System;
namespace CompetitiveProgramming.LeetCode.LargestColorValueinaDirectedGraph
{
    public class Solution
    {
        public static int LargestPathValue(string colors, int[][] edges)
        {
            int n = colors.Length;
            int k = 26;
            int[] indegrees = new int[n];
            int[,] counts = new int[n, k];
            int max_count = 0;
            int visited = 0;
            List<int>[] graph = new List<int>[n];
            HashSet<int> zero_indegree = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            foreach (int[] edge in edges)
            {
                int u = edge[0], v = edge[1];
                graph[u].Add(v);
                indegrees[v]++;
            }

            for (int i = 0; i < n; i++)
            {
                if (indegrees[i] == 0)
                {
                    zero_indegree.Add(i);
                }
            }

            for (int i = 0; i < n; i++)
            {
                counts[i, colors[i] - 'a']++;
            }

            while (zero_indegree.Count > 0)
            {
                int u = zero_indegree.First();
                zero_indegree.Remove(u);
                visited++;
                foreach (int v in graph[u])
                {
                    for (int i = 0; i < k; i++)
                    {
                        counts[v, i] = Math.Max(counts[v, i], counts[u, i] + (colors[v] - 'a' == i ? 1 : 0));
                    }
                    indegrees[v]--;

                    if (indegrees[v] == 0)
                    {
                        zero_indegree.Add(v);
                    }
                }
                max_count = Math.Max(max_count, Enumerable.Range(0, k).Select(i => counts[u, i]).Max());
            }
            return visited == n ? max_count : -1;
        }
    }
}
