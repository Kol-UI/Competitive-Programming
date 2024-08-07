// Remove Max Number of Edges to Keep Graph Fully Traversable

/*
Alice and Bob have an undirected graph of n nodes and three types of edges:

Type 1: Can be traversed by Alice only.
Type 2: Can be traversed by Bob only.
Type 3: Can be traversed by both Alice and Bob.
Given an array edges where edges[i] = [typei, ui, vi] represents a bidirectional edge of type typei between nodes ui and vi, find the maximum number of edges you can remove so that after removing the edges, the graph can still be fully traversed by both Alice and Bob. The graph is fully traversed by Alice and Bob if starting from any node, they can reach all other nodes.

Return the maximum number of edges you can remove, or return -1 if Alice and Bob cannot fully traverse the graph.

 

Example 1:



Input: n = 4, edges = [[3,1,2],[3,2,3],[1,1,3],[1,2,4],[1,1,2],[2,3,4]]
Output: 2
Explanation: If we remove the 2 edges [1,1,2] and [1,1,3]. The graph will still be fully traversable by Alice and Bob. Removing any additional edge will not make it so. So the maximum number of edges we can remove is 2.



Example 2:



Input: n = 4, edges = [[3,1,2],[3,2,3],[1,1,4],[2,1,4]]
Output: 0
Explanation: Notice that removing any edge will not make the graph fully traversable by Alice and Bob.



Example 3:



Input: n = 4, edges = [[3,2,3],[1,1,2],[2,3,4]]
Output: -1
Explanation: In the current graph, Alice cannot reach node 4 from the other nodes. Likewise, Bob cannot reach 1. Therefore it's impossible to make the graph fully traversable.
 

 

Constraints:

1 <= n <= 105
1 <= edges.length <= min(105, 3 * n * (n - 1) / 2)
edges[i].length == 3
1 <= typei <= 3
1 <= ui < vi <= n
All tuples (typei, ui, vi) are distinct.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.RemoveMaxNumberofEdgestoKeepGraphFullyTraversable
{
    public class Solution
    {
        public int MaxNumEdgesToRemove(int n, int[][] edges)
        {
            DSU dsu1 = new DSU(n);
            DSU dsu2 = new DSU(n);
            int count = 0;
            Array.Sort(edges, (a, b) => b[0] - a[0]);

            foreach(var edge in edges)
            {
                if(edge[0] == 3)
                {
                    if(dsu1.find(edge[1]) == dsu1.find(edge[2]) && dsu2.find(edge[1]) == dsu2.find(edge[2]))
                    {
                        count++;
                        continue;
                    }
                    
                    dsu1.union(edge[1], edge[2]);
                    dsu2.union(edge[1], edge[2]);
                }
                else if(edge[0] == 1)
                {
                    if(dsu1.find(edge[1]) == dsu1.find(edge[2]))
                    {
                        count++;
                    }

                    dsu1.union(edge[1], edge[2]);
                }
                else
                {
                    if(dsu2.find(edge[1]) == dsu2.find(edge[2]))
                    {
                        count++;
                    }

                    dsu2.union(edge[1], edge[2]);
                }
            }

            for(int i = 1; i <= n; i++)
            {
                dsu1.find(i);
                dsu2.find(i);
            }

            for(int i = 2; i <= n; i++)
            {
                if(dsu1.parent[i] != dsu1.parent[1] || dsu2.parent[i] != dsu2.parent[1])
                {
                    return -1;
                }
            }

            return count;
        }

        class DSU
        {
            public int[] parent;

            public DSU(int n)
            {
                parent = new int[n + 1];

                for (int i = 0; i <= n; i++) parent[i] = i;
            }

            public int find(int x)
            {
                if (parent[x] != x) parent[x] = find(parent[x]);
                return parent[x];
            }

            public void union(int x, int y)
            {
                parent[find(x)] = parent[find(y)];
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Max Number of Edges to Keep Graph Fully Traversable");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}