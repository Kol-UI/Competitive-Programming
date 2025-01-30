// Redundant Connection

namespace CompetitiveProgramming.LeetCode.RedundantConnection;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        int n = edges.Length;
        int[] parent = new int[n + 1];
        int[] rank = new int[n + 1];
        
        for (int i = 1; i <= n; i++) 
        {
            parent[i] = i;
            rank[i] = 0;
        }

        foreach (int[] edge in edges)
        {
            int root1 = Find(parent, edge[0]);
            int root2 = Find(parent, edge[1]);
            
            if (root1 == root2)
            {
                return edge;
            }

            Union(parent, rank, root1, root2);
        }
        
        return null!;
    }

    private int Find(int[] parent, int node)
    {
        if (parent[node] != node)
        {
            parent[node] = Find(parent, parent[node]);
        }
        return parent[node];
    }

    private void Union(int[] parent, int[] rank, int root1, int root2)
    {
        if (rank[root1] > rank[root2])
        {
            parent[root2] = root1;
        }
        else if (rank[root1] < rank[root2])
        {
            parent[root1] = root2;
        }
        else
        {
            parent[root2] = root1;
            rank[root1]++;
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Redundant Connection");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}