// Divide Nodes Into the Maximum Number of Groups

namespace CompetitiveProgramming.LeetCode.DivideNodesIntotheMaximumNumberofGroups;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MagnificentSets(int n, int[][] edges)
    {
        var adjList = new List<int>[n + 1];
        for (int i = 1; i <= n; i++) adjList[i] = new List<int>();
        int[] bestByMinN = new int[n + 1]; 
        int result = 0;
        var queue = new Queue<int>();
        var dist = new int[n + 1];

        foreach (var edge in edges)
        {
            adjList[edge[0]].Add(edge[1]);
            adjList[edge[1]].Add(edge[0]);
        }

        for (int i = 1; i <= n; i++)
        {
            if (adjList[i].Count == 0)
            { 
                result++; 
                continue; 
            }

            Array.Fill(dist, 0);
            dist[i] = 1;
            queue.Enqueue(i);
            int minNode = i, maxDist = 1;

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                int curDist = dist[node] + 1;
                foreach (int neighbor in adjList[node])
                {
                    if (dist[neighbor] > 0)
                    {
                        if ((dist[neighbor] & 1) != (curDist & 1)) return -1;
                    }
                    else
                    {
                        dist[neighbor] = curDist;
                        queue.Enqueue(neighbor);
                        maxDist = Math.Max(maxDist, curDist);
                        minNode = Math.Min(minNode, neighbor);
                    }
                }
            }

            int prevBest = bestByMinN[minNode];
            if (maxDist > prevBest)
            {
                result += maxDist - prevBest;
                bestByMinN[minNode] = maxDist;
            }
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Divide Nodes Into the Maximum Number of Groups");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}