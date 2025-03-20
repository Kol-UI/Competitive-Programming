// Minimum Cost Walk in Weighted Graph
namespace CompetitiveProgramming.LeetCode.MinimumCostWalkinWeightedGraph;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] MinimumCost(int n, int[][] edges, int[][] queries)
    {
        List<List<int[]>> adjList = new List<List<int[]>>(n);
        for (int i = 0; i < n; i++)
        {
            adjList.Add(new List<int[]>());
        }
        
        foreach (int[] edge in edges)
        {
            adjList[edge[0]].Add(new int[] { edge[1], edge[2] });
            adjList[edge[1]].Add(new int[] { edge[0], edge[2] });
        }
        
        bool[] visited = new bool[n];
        int[] components = new int[n];
        List<int> componentCost = new List<int>(n);
        int componentId = 0;
        
        for (int node = 0; node < n; node++)
        {
            if (!visited[node])
            {
                componentCost.Add(
                    GetComponentCost(node, adjList, visited, components, componentId)
                );
                componentId++;
            }
        }
        
        int[] answer = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0];
            int end = queries[i][1];
            if (components[start] == components[end])
            {
                answer[i] = componentCost[components[start]];
            }
            else
            {
                answer[i] = -1;
            }
        }
        
        return answer;
    }
    
    private int GetComponentCost(int source, List<List<int[]>> adjList, bool[] visited, int[] components, int componentId) {
        Queue<int> nodesQueue = new Queue<int>();
        int componentCost = int.MaxValue;
        
        nodesQueue.Enqueue(source);
        visited[source] = true;
        
        while (nodesQueue.Count > 0) {
            int node = nodesQueue.Dequeue();
            components[node] = componentId;
            
            foreach (int[] neighbor in adjList[node]) {
                int weight = neighbor[1];
                componentCost &= weight;
                
                if (!visited[neighbor[0]]) {
                    visited[neighbor[0]] = true;
                    nodesQueue.Enqueue(neighbor[0]);
                }
            }
        }
        
        return componentCost;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Cost Walk in Weighted Graph");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}