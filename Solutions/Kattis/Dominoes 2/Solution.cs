// Dominoes 2
namespace CompetitiveProgramming.Kattis.DominoesTwo;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Knock(List<int>[] adj, bool[] visited, int k)
    {
        if (visited[k]) return;
        visited[k] = true;

        foreach (int i in adj[k])
        {
            Knock(adj, visited, i);
        }
    }

    static void Main()
    {
        int cases = int.Parse(Console.ReadLine());
        while (cases-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);
            int l = int.Parse(firstLine[2]);

            List<int>[] adj = new List<int>[n];
            for (int i = 0; i < n; i++)
                adj[i] = new List<int>();

            for (int i = 0; i < m; i++)
            {
                string[] edge = Console.ReadLine().Split();
                int a = int.Parse(edge[0]) - 1;
                int b = int.Parse(edge[1]) - 1;
                adj[a].Add(b);
            }

            bool[] visited = new bool[n];
            for (int i = 0; i < l; i++)
            {
                int k = int.Parse(Console.ReadLine()) - 1;
                Knock(adj, visited, k);
            }

            int count = 0;
            foreach (bool v in visited)
                if (v) count++;

            Console.WriteLine(count);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Dominoes 2");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}