// Is Graph Bipartite

/*
There is an undirected graph with n nodes, where each node is numbered between 0 and n - 1. You are given a 2D array graph, where graph[u] is an array of nodes that node u is adjacent to. More formally, for each v in graph[u], there is an undirected edge between node u and node v. The graph has the following properties:

There are no self-edges (graph[u] does not contain u).
There are no parallel edges (graph[u] does not contain duplicate values).
If v is in graph[u], then u is in graph[v] (the graph is undirected).
The graph may not be connected, meaning there may be two nodes u and v such that there is no path between them.
A graph is bipartite if the nodes can be partitioned into two independent sets A and B such that every edge in the graph connects a node in set A and a node in set B.

Return true if and only if it is bipartite.


Example 1:

Input: graph = [[1,2,3],[0,2],[0,1,3],[0,2]]
Output: false
Explanation: There is no way to partition the nodes into two independent sets such that every edge connects a node in one and a node in the other.


Example 2:

Input: graph = [[1,3],[0,2],[1,3],[0,2]]
Output: true
Explanation: We can partition the nodes into two sets: {0, 2} and {1, 3}.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IsGraphBipartite
{
    public class Solution
    {
        public static bool IsBipartite(int[][] graph)
        {
            int n = graph.Length;
            int[] s = new int[n];
            Queue<int> q = new Queue<int>();
            Array.Fill(s, -1);

            for(int i =0; i< n; i++)
            {
                if(s[i] == -1)
                {
                    s[i] = 0;
                    q.Enqueue(i);
                    while(q.Count > 0)
                    {
                        var nnode = q.Dequeue();
                        foreach(var nn in graph[nnode])
                        {
                            if(s[nn] == -1)
                            {
                                s[nn] = (s[nnode]+1)%2;
                                q.Enqueue(nn);
                            }

                            else if(s[nn] != (s[nnode]+1)%2) return false;
                        }
                    }
                }
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestIsGraphBipartite()
        {
            int[][] case1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 0, 2 },
                new int[] { 0, 1, 3 },
                new int[] { 0, 2 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 0, 2 },
                new int[] { 1, 3 },
                new int[] { 0, 2 }
            };

            bool result1 = Solution.IsBipartite(case1);
            bool result2 = Solution.IsBipartite(case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, false),
                ResultTester.CheckResult<bool>(result2, true)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Is Graph Bipartite");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestIsGraphBipartite());
        }
    }
}