// Find Critical and Pseudo-Critical Edges in Minimum Spanning Tree

/*
Given a weighted undirected connected graph with n vertices numbered from 0 to n - 1, and an array edges where edges[i] = [ai, bi, weighti] represents a bidirectional and weighted edge between nodes ai and bi. A minimum spanning tree (MST) is a subset of the graph's edges that connects all vertices without cycles and with the minimum possible total edge weight.

Find all the critical and pseudo-critical edges in the given graph's minimum spanning tree (MST). An MST edge whose deletion from the graph would cause the MST weight to increase is called a critical edge. On the other hand, a pseudo-critical edge is that which can appear in some MSTs but not all.

Note that you can return the indices of the edges in any order.

 

Example 1:

Input: n = 5, edges = [[0,1,1],[1,2,1],[2,3,2],[0,3,2],[0,4,3],[3,4,3],[1,4,6]]
Output: [[0,1],[2,3,4,5]]
Explanation: The figure above describes the graph.
The following figure shows all the possible MSTs:

Notice that the two edges 0 and 1 appear in all MSTs, therefore they are critical edges, so we return them in the first list of the output.
The edges 2, 3, 4, and 5 are only part of some MSTs, therefore they are considered pseudo-critical edges. We add them to the second list of the output.

Example 2:

Input: n = 4, edges = [[0,1,1],[1,2,1],[2,3,1],[0,3,1]]
Output: [[],[0,1,2,3]]
Explanation: We can observe that since all 4 edges have equal weight, choosing any 3 edges from the given 4 will yield an MST. Therefore all 4 edges are pseudo-critical.

*/

using CompetitiveProgramming;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindCriticalandPseudoCriticalEdgesInMinimumSpanningTree;
public class Solution
{
        internal class UnionFind
        {
            int[] parent;
            int cost;
            int setCount;
            public UnionFind(int n)
            {
                this.parent = Enumerable.Range(0, n).ToArray();
                this.cost = 0;
                this.setCount = n;
            }

            public void ProcessEdge(int[] arr)
            {
                int p1 = findParent(arr[0]);
                int p2 = findParent(arr[1]);

                if (p1 != p2)
                {
                    parent[p1] = p2;
                    setCount--;

                    cost += arr[2];
                }
            }

            private int findParent(int c)
            {
                if (parent[c] == c) return c;

                return findParent(parent[c]);

            }

            internal int GetCost()
            {
                return setCount > 1 ? int.MaxValue : cost;
            }
        }

        public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
        {
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> critical = new List<int>();
            IList<int> pseudoCritical = new List<int>();

            result.Add(critical);
            result.Add(pseudoCritical);

            UnionFind uf = new UnionFind(n);

            Dictionary<int, int[]> edgeDictionary = new Dictionary<int, int[]>();

            for (int i = 0; i < edges.Length; i++)
            {
                edgeDictionary.Add(i, edges[i]);
            }

            edgeDictionary = edgeDictionary.OrderBy(x => x.Value[2]).ToDictionary(x => x.Key, x => x.Value);
            foreach (int key in edgeDictionary.Keys)
            {
                uf.ProcessEdge(edgeDictionary[key]);
            }

            int mst = uf.GetCost();

            for (int i = 0; i < edgeDictionary.Keys.Count; i++)
            {

                uf = new UnionFind(n);
                foreach (var key in edgeDictionary.Keys)
                {
                    if (key == i) continue;
                    uf.ProcessEdge(edgeDictionary[key]);
                }

                int excludeCost = uf.GetCost();
                if (excludeCost > mst)
                {
                    critical.Add(i);
                }
                else
                {
                    uf = new UnionFind(n);
                    uf.ProcessEdge(edgeDictionary[i]);

                    foreach (var key in edgeDictionary.Keys)
                    {
                        if (key == i) continue;
                        uf.ProcessEdge(edgeDictionary[key]);
                    }
                    int includeCost = uf.GetCost();
                    if (includeCost == mst)
                    {
                        pseudoCritical.Add(i);
                    }
                }
            }

            return result;
        }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Critical and Pseudo Critical Edges in Minimum Spanning Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}