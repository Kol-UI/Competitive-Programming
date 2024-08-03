using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTimetoCollectAllApplesinaTree
{
    public class Solution
    {
        //Given an undirected tree consisting of n vertices numbered from 0 to n-1,
        //    which has some apples in their vertices.You spend 1 second to walk over one edge of the tree.
        //Return the minimum time in seconds you have to spend to collect all apples in the tree,
        //    starting at vertex 0 and coming back to this vertex.
        //The edges of the undirected tree are given in the array edges,
        //    where edges[i] = [ai, bi] means that exists an edge connecting the vertices ai and bi.
        //Additionally, there is a boolean array hasApple, where hasApple[i] = true means that vertex i has an apple;
        //    otherwise, it does not have any apple.

        //Example 1:
        //Given an undirected tree consisting of n vertices numbered from 0 to n-1, which has some apples in their vertices.
        //You spend 1 second to walk over one edge of the tree.
        //Return the minimum time in seconds you have to spend to collect all apples in the tree, starting at vertex 0 and coming back to this vertex.
        //The edges of the undirected tree are given in the array edges, where edges[i] = [ai, bi] means that exists an edge connecting the vertices ai and bi.
        //Additionally, there is a boolean array hasApple, where hasApple[i] = true means that vertex i has an apple; otherwise, it does not have any apple.


        //Example 2:
        //Input: n = 7, edges = [[0, 1], [0,2], [1,4], [1,5], [2,3], [2,6]], hasApple = [false,false,true,false,false,true,false]
        //Output: 6
        //Explanation: The figure above represents the given tree where red vertices have an apple.One optimal path to collect all apples is shown by the green arrows.


        //Example 3:
        //Input: n = 7, edges = [[0,1],[0,2],[1,4],[1,5],[2,3],[2,6]], hasApple = [false,false,false,false,false,false,false]
        //Output: 0

        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            var adj = new Dictionary<int, List<int>>();
            foreach (int[] edge in edges)
            {
                int a = edge[0];
                int b = edge[1];
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
            return DFS(0, -1, adj, hasApple);
        }

        public int DFS(int node, int parent, Dictionary<int, List<int>> adj, IList<bool> hasApple)
        {
            if (!adj.ContainsKey(node))
            {
                return 0;
            }

            int totalTime = 0;
            foreach (int child in adj[node])
            {
                if (child == parent)
                {
                    continue;
                }
                int childTime = DFS(child, node, adj, hasApple);
                if (childTime > 0 || hasApple[child])
                {
                    totalTime += childTime + 2;
                }
            }
            return totalTime;
        }

    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Time to Collect All Apples in a Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}