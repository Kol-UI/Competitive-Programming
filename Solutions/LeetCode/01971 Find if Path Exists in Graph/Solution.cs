using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindifPathExistsinGraph
{
    public class Solution
    {
        //There is a bi-directional graph with n vertices, where each vertex is labeled from 0 to n - 1 (inclusive).
        //The edges in the graph are represented as a 2D integer array edges, where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui and vertex vi.
        //Every vertex pair is connected by at most one edge, and no vertex has an edge to itself.

        //You want to determine if there is a valid path that exists from vertex source to vertex destination.
        //Given edges and the integers n, source, and destination, return true if there is a valid path from source to destination, or false otherwise.

        public static bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (source == destination)
                return true;
            UnionFind uf = new UnionFind(n);
            foreach (int[] edge in edges)
            {
                uf.Union(edge[0], edge[1]);
            }
            return uf.Find(source) == uf.Find(destination);
        }
    }

    public class UnionFind
    {
        public int[] root;
        readonly int[] rank;

        public UnionFind(int size)
        {
            root = new int[size];
            rank = new int[size];
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
                rank[i] = 1;
            }
        }

        public int Find(int x)
        {
            if (root[x] == x)
                return x;
            return root[x] = Find(root[x]);
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                if (rank[rootX] > rank[rootY])
                    root[rootY] = rootX;
                else if (rank[rootY] > rank[rootX])
                    root[rootX] = rootY;
                else
                {
                    root[rootY] = rootX;
                    rank[rootX] += 1;
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1971");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}