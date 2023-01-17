using System;
namespace CompetitiveProgramming.LeetCode.NumberofGoodPaths
{
	public class Solution
    {
        //There is a tree(i.e.a connected, undirected graph with no cycles) consisting of n nodes numbered from 0 to n - 1 and exactly n - 1 edges.
        //You are given a 0-indexed integer array vals of length n where vals[i] denotes the value of the ith node.You are also given a 2D integer array edges where edges[i] = [ai, bi] denotes that there exists an undirected edge connecting nodes ai and bi.

        //A good path is a simple path that satisfies the following conditions:

        //The starting node and the ending node have the same value.
        //All nodes between the starting node and the ending node have values less than or equal to the starting node (i.e.the starting node's value should be the maximum value along the path).
        //Return the number of distinct good paths.
        //Note that a path and its reverse are counted as the same path.For example, 0 -> 1 is considered to be the same as 1 -> 0. A single node is also considered as a valid path.

        //Example 1:
        //Input: vals = [1, 3, 2, 1, 3], edges = [[0, 1], [0,2], [2,3], [2,4]]
        //Output: 6
        //Explanation: There are 5 good paths consisting of a single node.
        //There is 1 additional good path: 1 -> 0 -> 2 -> 4.
        //(The reverse path 4 -> 2 -> 0 -> 1 is treated as the same as 1 -> 0 -> 2 -> 4.)
        //Note that 0 -> 2 -> 3 is not a good path because vals[2] > vals[0].

        //Example 2:
        //Input: vals = [1,1,2,2,3], edges = [[0,1],[1,2],[2,3],[2,4]]
        //Output: 7
        //Explanation: There are 5 good paths consisting of a single node.
        //There are 2 additional good paths: 0 -> 1 and 2 -> 3.

        //Example 3:
        //Input: vals = [1], edges = []
        //Output: 1
        //Explanation: The tree consists of only one node, so there is one good path.

        int[] parents, count, vals;
        int res;

        public int NumberOfGoodPaths(int[] vals, int[][] edges)
        {
            this.vals = vals;
            Array.Sort(edges, (a, b) => Math.Max(vals[a[0]], vals[a[1]]) - Math.Max(vals[b[0]], vals[b[1]]));
            res = vals.Length;
            parents = new int[vals.Length];
            for (int i = 0; i < vals.Length; i++) parents[i] = i;
            count = new int[vals.Length];
            foreach (int[] edge in edges)
            {
                Union(edge[0], edge[1]);
            }
            return res;
        }

        bool Union(int a, int b)
        {
            int pa = Parent(a);
            int pb = Parent(b);
            if (pa == pb) return false;
            if (vals[pa] == vals[pb])
            {
                res += (count[pa] + 1) * (count[pb] + 1);
                count[pa] += count[pb] + 1;
                parents[pb] = pa;
            }
            else if (vals[pa] > vals[pb]) parents[pb] = pa;
            else parents[pa] = pb;
            return true;
        }

        private int Parent(int a)
        {
            int p;
            if ((p = parents[a]) != a) p = parents[a] = Parent(p);
            return p;
        }
    }
}

