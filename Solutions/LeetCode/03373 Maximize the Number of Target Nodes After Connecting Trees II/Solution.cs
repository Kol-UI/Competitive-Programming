// Maximize the Number of Target Nodes After Connecting Trees II
namespace CompetitiveProgramming.LeetCode.MaximizetheNumberofTargetNodesAfterConnectingTreesII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    private List<int>[] CreateAdj(int[][] edges)
    {
        int n = edges.Length + 1;
        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
        }

        foreach (int[] edge in edges)
        { 
            int from = edge[0], to = edge[1];
            adj[from].Add(to);
            adj[to].Add(from);
        }

        return adj;
    }

    private int DFSEvenNodes(int idx, int par, List<int>[] adj, ref bool[] parity, bool even = true)
    {
        int target = even ? 1 : 0;
        parity[idx] = even;
        foreach (int next in adj[idx])
        {
            if (next != par)
                target += DFSEvenNodes(next, idx, adj, ref parity, !even);
        }

        return target;
    }

    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2) {
        int m = edges1.Length+1, n = edges2.Length+1;
        int[] res = new int[m];
        bool[] evenArr = new bool[m], tmp = new bool[n];

        int even1 = DFSEvenNodes(0, -1, CreateAdj(edges1), ref evenArr);
        int odd1 = m - even1;

        int even2 = DFSEvenNodes(0, -1, CreateAdj(edges2), ref tmp);
        int odd2 = n - even2;

        for (int i = 0; i < m; i++)
        {
            res[i] = Math.Max(even2, odd2) + (evenArr[i] ? even1 : odd1);
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Maximize the Number of Target Nodes After Connecting Trees II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
	}
}