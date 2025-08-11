// Number of Ways to Assign Edge Weights I
namespace CompetitiveProgramming.LeetCode.NumberofWaystoAssignEdgeWeightsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int GetDepth()
    {
        int steps = 0;
        Queue<int> que = new();
        que.Enqueue(1);

        bool[] visited = Enumerable.Repeat(false, n+1).ToArray();
        while(que.Count > 0)
        {
            int qLen = que.Count;
            for(int i = 0; i < qLen; i++)
            {
                int cur = que.Dequeue();
                if(visited[cur])
                    continue;

                visited[cur] = true;
                foreach(int neigh in adjs![cur])
                {
                    if(!visited[neigh])
                        que.Enqueue(neigh);
                }
            }

            steps++;
        }

        return steps;
    }
    
    private int mod = 1000000007;
 
    private long ModPow(long _base, long exp)
    {
        long res = 1, b = _base % mod;

        while (exp > 0)
        {
            if ((exp & 1) == 1) 
                res = (res * b) % mod;

            b = (b * b) % mod;
            exp >>= 1;
        }
        return res;
    }
 
    private List<int>[]? adjs;

    private int n;

    private void BuildEdge(int[][] edges)
    {
        adjs = new List<int>[n+1];
        for(int i = 1; i <= n; i++)
        {
            adjs[i] = new List<int>();
        }

        foreach(int[] cur in edges)
        {
            int from = cur[0], to = cur[1];
            adjs[from].Add(to);
            adjs[to].Add(from);
        }
    }

    public int AssignEdgeWeights(int[][] edges)
    {
        n = edges.Length+1;
        BuildEdge(edges);
        int depth = GetDepth()-1;
        return (int)ModPow(2, depth - 1);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Ways to Assign Edge Weights I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}