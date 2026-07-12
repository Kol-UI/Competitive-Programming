// Elevator Trouble
namespace CompetitiveProgramming.Kattis.ElevatorTrouble;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int f = int.Parse(input[0]);
        int s = int.Parse(input[1]);
        int g = int.Parse(input[2]);
        int u = int.Parse(input[3]);
        int d = int.Parse(input[4]);

        if (s == g)
        {
            Console.WriteLine(0);
            return;
        }

        s--;
        g--;

        int?[] dist = new int?[f];
        dist[s] = 0;

        Queue<int> q = new Queue<int>();
        q.Enqueue(s);

        while (q.Count > 0)
        {
            int x = q.Dequeue();
            if (x == g) break;

            int[] next = { x + u, x - d };
            foreach (int v in next)
            {
                if (v >= 0 && v < f && dist[v] == null)
                {
                    dist[v] = dist[x] + 1;
                    q.Enqueue(v);
                }
            }
        }

        Console.WriteLine(dist[g] != null ? dist[g].ToString() : "use the stairs");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Elevator Trouble");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}