using System;
namespace CompetitiveProgramming.LeetCode.CountUnreachablePairsofNodesinanUndirectedGraph
{
    /*
        You are given an integer n. There is an undirected graph with n nodes, numbered from 0 to n - 1. You are given a 2D integer array edges where edges[i] = [ai, bi] denotes that there exists an undirected edge connecting nodes ai and bi.
        Return the number of pairs of different nodes that are unreachable from each other.

        Example 1:
        Input: n = 3, edges = [[0,1],[0,2],[1,2]]
        Output: 0
        Explanation: There are no pairs of nodes that are unreachable from each other. Therefore, we return 0.
        
        Example 2:
        Input: n = 7, edges = [[0,2],[0,5],[2,4],[1,6],[5,4]]
        Output: 14
        Explanation: There are 14 pairs of nodes that are unreachable from each other:
        [[0,1],[0,3],[0,6],[1,2],[1,3],[1,4],[1,5],[2,3],[2,6],[3,4],[3,5],[3,6],[4,6],[5,6]].
        Therefore, we return 14.
    */

    public class Solution
    {
        public static long CountPairs(int n, int[][] edges)
        {
            var parent = new int[n];
            var rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }

            foreach (var edge in edges)
            {
                int v1 = edge[0];
                int v2 = edge[1];
                int r1 = GetRoot(parent, v1);
                int r2 = GetRoot(parent, v2);
                if (r1 != r2)
                {
                    if (rank[r1] < rank[r2])
                    {
                        (r1, r2) = (r2, r1);
                    }

                    parent[r2] = r1;
                    rank[r1] += rank[r2];
                }
            }

            var dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int r = GetRoot(parent, i);
                dict[r] = dict.GetValueOrDefault(r, 0) + 1;
            }

            var values = dict.Values.ToArray();
            long sum = 0;
            foreach (var value in values)
            {
                sum += (long)value * (n - value);
            }

            return sum / 2;
        }

        private static int GetRoot(int[] parents, int v)
        {
            while (v != parents[v])
            {
                parents[v] = parents[parents[v]];
                v = parents[v];
            }

            return v;
        }
    }
}