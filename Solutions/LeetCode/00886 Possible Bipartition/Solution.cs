using System;
namespace CompetitiveProgramming.LeetCode.PossibleBipartition
{
    public class Solution
    {
        //We want to split a group of n people(labeled from 1 to n) into two groups of any size.Each person may dislike some other people, and they should not go into the same group.
        //Given the integer n and the array dislikes where dislikes[i] = [ai, bi] indicates that the person labeled ai does not like the person labeled bi, return true if it is possible to split everyone into two groups in this way.
        //Example 1:
        //Input: n = 4, dislikes = [[1, 2], [1,3], [2,4]]
        //Output: true
        //Explanation: group1[1, 4] and group2[2, 3].
        //Example 2:
        //Input: n = 3, dislikes = [[1,2],[1,3],[2,3]]
        //Output: false
        //Example 3:
        //Input: n = 5, dislikes = [[1,2],[2,3],[3,4],[4,5],[1,5]]
        //Output: false

        public static bool PossibleBipartition(int n, int[][] dislikes)
        {
            var adj = new Dictionary<int, List<int>>();
            foreach (int[] edge in dislikes)
            {
                int a = edge[0], b = edge[1];
                if (!adj.ContainsKey(a))
                {
                    adj[a] = new List<int>();
                }
                if (!adj.ContainsKey(b))
                {
                    adj[b] = new List<int>();
                }
                adj[a].Add(b);
                adj[b].Add(a);
            }

            var dsu = new UnionFindSet(n + 1);
            for (int node = 1; node <= n; ++node)
            {
                if (!adj.ContainsKey(node))
                {
                    continue;
                }
                foreach (int neighbor in adj[node])
                {
                    if (dsu.Find(node) == dsu.Find(neighbor))
                    {
                        return false;
                    }
                    dsu.Union(adj[node][0], neighbor);
                }
            }
            return true;
        }

        public class UnionFindSet
        {
            private int[] parent;
            public UnionFindSet(int size)
            {
                parent = new int[size];
                for (int i = 0; i < parent.Length; ++i)
                {
                    parent[i] = i;
                }
            }
            public void Union(int x, int y)
            {
                parent[Find(x)] = parent[Find(y)];
            }
            public int Find(int x)
            {
                if (parent[x] != x)
                {
                    parent[x] = Find(parent[x]);
                }
                return parent[x];
            }
        }
    }
}

