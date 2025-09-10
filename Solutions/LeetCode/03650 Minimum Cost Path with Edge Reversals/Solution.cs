// Minimum Cost Path with Edge Reversals
namespace CompetitiveProgramming.LeetCode.MinimumCostPathwithEdgeReversals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinCost(int n, int[][] edges)
    {
        List<(int, int)>[] adjs = new List<(int, int)>[n];

        for(int i = 0; i < n; i++)
        {
            adjs[i] = new List<(int, int)>();
        }

        foreach(int[] edge in edges)
        {
            int from = edge[0], to = edge[1], cost = edge[2];
            adjs[from].Add((to, cost));
            adjs[to].Add((from, cost*2));
        }

        PriorityQueue<int, int> pq = new();
        pq.Enqueue(0, 0);
        bool[] visited = new bool[n];
        while(pq.TryDequeue(out int node, out int step))
        {
            if(node == n-1)
                return step;

            if(visited[node])
                continue;

            visited[node] = true;
            foreach((int to, int cost) in adjs[node])
            {
                if(visited[to])
                    continue;

                pq.Enqueue(to, step+cost);
            }
        }

        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Cost Path with Edge Reversals");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}