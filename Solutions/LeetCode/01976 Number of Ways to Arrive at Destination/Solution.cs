// Number of Ways to Arrive at Destination
namespace CompetitiveProgramming.LeetCode.NumberofWaystoArriveatDestination;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountPaths(int n, int[][] roads)
    {
        const int MOD = 1_000_000_007;
        List<(int, int)>[] graph = new List<(int, int)>[n];
        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<(int, int)>();
        }
        foreach (var road in roads)
        {
            int u = road[0], v = road[1], time = road[2];
            graph[u].Add((v, time));
            graph[v].Add((u, time));
        }
        long[] dist = new long[n];
        int[] ways = new int[n];
        Array.Fill(dist, long.MaxValue);
        dist[0] = 0;
        ways[0] = 1;

        var pq = new SortedSet<(long, int)> { (0, 0) }; 

        while (pq.Count > 0)
        {
            var (timeTaken, node) = pq.Min;
            pq.Remove(pq.Min);
            foreach (var (nextNode, travelTime) in graph[node])
            {
                long newTime = timeTaken + travelTime;
                if (newTime < dist[nextNode])
                {
                    pq.Remove((dist[nextNode], nextNode)); 
                    dist[nextNode] = newTime;
                    ways[nextNode] = ways[node]; 
                    pq.Add((newTime, nextNode));
                }
                else if (newTime == dist[nextNode])
                {
                    ways[nextNode] = (ways[nextNode] + ways[node]) % MOD;
                }
            }
        }

        return ways[n - 1];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Ways to Arrive at Destination");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}