// Palindromic Path Queries in a Tree
namespace CompetitiveProgramming.LeetCode.PalindromicPathQueriesinaTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8618

public class Solution {
    private int n;
    private List<int>[] adj;
    private int[] tin;
    private int[] tout;
    private int timer;
    private int[,] up;
    private int LOG;
    
    private int[] bit;

    private void UpdateBIT(int idx, int val) {
        for (; idx < bit.Length; idx += idx & -idx) {
            bit[idx] ^= val;
        }
    }

    private int QueryBIT(int idx) {
        int sum = 0;
        for (; idx > 0; idx -= idx & -idx) {
            sum ^= bit[idx];
        }
        return sum;
    }

    public bool[] PalindromePath(int n, int[][] edges, string s, string[] queries) {
        this.n = n;
        adj = new List<int>[n];
        for (int i = 0; i < n; i++) adj[i] = new List<int>();
        
        foreach (var edge in edges) {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        tin = new int[n];
        tout = new int[n];
        timer = 1;
        LOG = (int)Math.Ceiling(Math.Log2(n)) + 1;
        up = new int[n, LOG];

        Dfs(0, 0);

        bit = new int[2 * n + 2];
        char[] currentChars = s.ToCharArray();

        for (int i = 0; i < n; i++) {
            int mask = 1 << (currentChars[i] - 'a');
            UpdateBIT(tin[i], mask);
            UpdateBIT(tout[i], mask);
        }

        List<bool> results = new List<bool>();

        foreach (var queryStr in queries) {
            string[] parts = queryStr.Split(' ');
            
            if (parts[0] == "update") {
                int node = int.Parse(parts[1]);
                char newChar = parts[2][0];
                
                int oldMask = 1 << (currentChars[node] - 'a');
                int newMask = 1 << (newChar - 'a');

                UpdateBIT(tin[node], oldMask);
                UpdateBIT(tout[node], oldMask);

                UpdateBIT(tin[node], newMask);
                UpdateBIT(tout[node], newMask);

                currentChars[node] = newChar;
            } 
            else {
                int u = int.Parse(parts[1]);
                int v = int.Parse(parts[2]);
                int lcaNode = GetLCA(u, v);

                int maskU = QueryBIT(tin[u]);
                int maskV = QueryBIT(tin[v]);
                int maskLcaNode = 1 << (currentChars[lcaNode] - 'a');

                int pathMask = maskU ^ maskV ^ maskLcaNode;

                bool canFormPalindrome = (pathMask & (pathMask - 1)) == 0;
                results.Add(canFormPalindrome);
            }
        }

        return results.ToArray();
    }

    private void Dfs(int u, int p) {
        tin[u] = timer++;
        up[u, 0] = p;
        
        for (int i = 1; i < LOG; i++) {
            up[u, i] = up[up[u, i - 1], i - 1];
        }

        foreach (int v in adj[u]) {
            if (v != p) {
                Dfs(v, u);
            }
        }
        tout[u] = timer++;
    }

    private bool IsAncestor(int u, int v) {
        return tin[u] <= tin[v] && tout[u] >= tout[v];
    }

    private int GetLCA(int u, int v) {
        if (IsAncestor(u, v)) return u;
        if (IsAncestor(v, u)) return v;

        for (int i = LOG - 1; i >= 0; i--) {
            if (!IsAncestor(up[u, i], v)) {
                u = up[u, i];
            }
        }
        return up[u, 0];
    }
}

#pragma warning restore CS8618
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Palindromic Path Queries in a Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}