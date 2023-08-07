// Shortest Path Visiting All Nodes

/*
You have an undirected, connected graph of n nodes labeled from 0 to n - 1. You are given an array graph where graph[i] is a list of all the nodes connected with node i by an edge.

Return the length of the shortest path that visits every node. You may start and stop at any node, you may revisit nodes multiple times, and you may reuse edges.

 

Example 1:


Input: graph = [[1,2,3],[0],[0],[0]]
Output: 4
Explanation: One possible path is [1,0,2,0,3]
Example 2:


Input: graph = [[1],[0,2,4],[1,3,4],[2],[1,2]]
Output: 4
Explanation: One possible path is [0,1,4,2,3]
*/


using System;
namespace CompetitiveProgramming.LeetCode.ShortestPathVisitingAllNodes
{
        public class Solution
        {
            private int Helper(int visited, int max, int[,] edgesMovement, int[][] graph, int node, IDictionary<(int node, int visited), int> cache)
            {
                if (visited == max)
                {
                    return 0;
                }

                var key = (node, visited);
                if (cache.ContainsKey(key))
                {
                    return cache[key];
                }

                visited |= (1 << node);

                int res = int.MaxValue;
                foreach (var next in graph[node])
                {
                    if ((visited & (1 << next)) == 0 || edgesMovement[node, next] != 2)
                    {
                        edgesMovement[node, next]++;
                        edgesMovement[next, node]++;
                        int inner = Helper(visited, max, edgesMovement, graph, next, cache);
                        if (inner != int.MaxValue)
                        {
                            res = Math.Min(res, inner + 1);
                        }
                        edgesMovement[node, next]--;
                        edgesMovement[next, node]--;
                    }
                }

                cache[key] = res;
                return res;
            }

            public int ShortestPathLength(int[][] graph)
            {
                int n = graph.Length;
                if (n == 0)
                {
                    return 0;
                }

                if (n == 1)
                {
                    return 0;
                }

                int[,] edgesMovement = new int[n,n];
                int max = (int)Math.Pow(2, n) - 1;

                int res = int.MaxValue;
                IDictionary<(int node, int visited), int> cache = new Dictionary<(int node, int visited), int>();
                for (int i = 0; i < n; i++)
                {
                    var cand = Helper(0, max, edgesMovement, graph, i, cache);
                    res = Math.Min(res, cand);
                }

                return res - 1;
            }
        }
}