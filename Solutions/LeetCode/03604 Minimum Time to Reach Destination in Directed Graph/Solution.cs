// Minimum Time to Reach Destination in Directed Graph
namespace CompetitiveProgramming.LeetCode.MinimumTimetoReachDestinationinDirectedGraph;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int MinTime(int n, int[][] edges) 
    {
        var graph = BuildGraph(n, edges);
        var distances = InitializeDistances(n);
        var priorityQueue = new PriorityQueue<(int Node, int Time), int>();

        priorityQueue.Enqueue((0, 0), 0);
        distances[0] = 0;

        while (priorityQueue.Count > 0)
        {
            var (currentNode, currentTime) = priorityQueue.Dequeue();
            
            foreach (var edge in graph[currentNode])
            {
                var (neighborNode, startTime, endTime) = (edge[0], edge[1], edge[2]);
                var waitTime = CalculateWaitTime(currentTime, startTime, endTime);

                if (waitTime == null) continue;

                var arrivalTime = currentTime + waitTime.Value + 1;
                
                if (arrivalTime < distances[neighborNode])
                {
                    distances[neighborNode] = arrivalTime;
                    priorityQueue.Enqueue((neighborNode, arrivalTime), arrivalTime);
                }
            }
        }

        return distances[n - 1] == int.MaxValue ? -1 : distances[n - 1];
    }

    private Dictionary<int, List<int[]>> BuildGraph(int n, int[][] edges)
    {
        var graph = new Dictionary<int, List<int[]>>();
        
        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int[]>();
        }

        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1], st = edge[2], en = edge[3];
            graph[u].Add(new[] { v, st, en });
        }

        return graph;
    }

    private int[] InitializeDistances(int n)
    {
        var distances = new int[n];
        Array.Fill(distances, int.MaxValue);
        return distances;
    }

    private int? CalculateWaitTime(int currentTime, int startTime, int endTime)
    {
        if (currentTime >= startTime && currentTime <= endTime)
        {
            return 0;
        }
        else if (currentTime < startTime)
        {
            return startTime - currentTime;
        }
        
        return null;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Time to Reach Destination in Directed Graph");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}