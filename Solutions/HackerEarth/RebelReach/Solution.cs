// RebelReach
namespace CompetitiveProgramming.HackerEarth.RebelReach;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    static public void Main()
    {
        String line = Console.ReadLine();
        int T = Convert.ToInt32(line);
        
        for(int t = 0; t < T; t++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<int>[] graph = new List<int>[N + 1];
            for(int i = 1; i <= N; i++) graph[i] = new List<int>();
            
            for(int i = 0; i < N - 1; i++)
            {
                var parts = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int u = parts[0];
                int v = parts[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }
            
            int[] guards = new int[N + 1];
            var guardList = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i = 0; i < N; i++) guards[i + 1] = guardList[i];
            
            int Q = Convert.ToInt32(Console.ReadLine());
            
            int[] parent = new int[N + 1];
            bool[] visited = new bool[N + 1];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            visited[1] = true;
            parent[1] = 0;
            
            while(queue.Count > 0)
            {
                int current = queue.Dequeue();
                foreach(int neighbor in graph[current])
                {
                    if(!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        parent[neighbor] = current;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            
            for(int i = 0; i < Q; i++)
            {
                var parts = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int startCity = parts[0];
                int rebels = parts[1];
                
                int currentCity = startCity;
                int remainingRebels = rebels;
                
                while(currentCity != 1)
                {
                    if(remainingRebels > guards[currentCity])
                    {
                        remainingRebels -= guards[currentCity];
                        currentCity = parent[currentCity];
                    }
                    else
                    {
                        break;
                    }
                }
                
                Console.WriteLine(currentCity);
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("RebelReach");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.HardHE);
    }
}