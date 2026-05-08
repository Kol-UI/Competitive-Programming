// Weak Vertices
namespace CompetitiveProgramming.Kattis.WeakVertices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == -1) break;
            
            int[][] adj = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                adj[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    adj[i][j] = int.Parse(input[j]);
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                bool isTri = false;
                for (int j = 0; j < n; j++)
                {
                    if (adj[i][j] == 0) continue;
                    for (int k = j + 1; k < n; k++)
                    {
                        if (adj[i][k] == 0) continue;
                        if (adj[j][k] == 1)
                        {
                            isTri = true;
                            break;
                        }
                    }
                    if (isTri) break;
                }
                if (!isTri)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
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
        StyleHelper.Title("Weak Vertices");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}