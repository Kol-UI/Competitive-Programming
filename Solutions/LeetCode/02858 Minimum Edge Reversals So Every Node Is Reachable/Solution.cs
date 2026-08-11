// Minimum Edge Reversals So Every Node Is Reachable
namespace CompetitiveProgramming.LeetCode.MinimumEdgeReversalsSoEveryNodeIsReachable;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8618
public class Solution
{
    Dictionary<int,List<int>> g;
    HashSet<(int,int)> original;
    int[] answer;
    
    private int DFS(int curr, int p)
    {
        int ans = 0;
        foreach(var next in g[curr])
        {
            if (next == p) continue;
            ans += DFS(next,curr) + (original.Contains((curr,next)) ? 0 : 1);
        }
        return ans;
    }
    
    private void Reroot(int curr, int p)
    {
        answer[curr] = answer[p] + (original.Contains((curr,p)) ? -1 : 1);
        foreach(var next in g[curr])
        {
            if (next == p) continue;
            Reroot(next,curr);
        }
    }
    
    public int[] MinEdgeReversals(int n, int[][] edges)
    {
        answer = new int[n];
        original = new();
        g = new();
        
        foreach(var edge in edges)
        {
            original.Add((edge[0], edge[1]));
            if (!g.ContainsKey(edge[0])) g.Add(edge[0], new());
            if (!g.ContainsKey(edge[1])) g.Add(edge[1], new());
            g[edge[0]].Add(edge[1]);
            g[edge[1]].Add(edge[0]);
        }
        
        answer[0] = DFS(0,-1);
        foreach(var next in g[0])
        {
            Reroot(next,0);
        }
        return answer;
    }
}
#pragma warning restore CS8618

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.MinEdgeReversals(4, [[2,0],[2,1],[1,3]]), [1,1,0,2]),
            ResultTester.CheckResult<int[]>(solution.MinEdgeReversals(3, [[1,2],[2,0]]), [2,0,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Edge Reversals So Every Node Is Reachable");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}