// Breaking Bad
namespace CompetitiveProgramming.Kattis.BreakingBad;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8601

using System;
using System.Collections.Generic;

class Program
{
    const int mxN = 100005;
    static string[] item = new string[mxN];
    static Dictionary<string, int> id = new Dictionary<string, int>();
    static List<int>[] adj = new List<int>[mxN];
    static int[] col = new int[mxN];

    static bool Dfs(int u)
    {
        foreach (int v in adj[u])
        {
            if (col[v] == 0)
            {
                col[v] = 3 ^ col[u];
                if (!Dfs(v)) return false;
            }
            else if (col[v] == col[u])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            item[i] = Console.ReadLine();
            id[item[i]] = i;
            adj[i] = new List<int>();
        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split();
            string s = input[0];
            string t = input[1];
            int u = id[s];
            int v = id[t];
            adj[u].Add(v);
            adj[v].Add(u);
        }

        for (int i = 0; i < n; i++)
        {
            if (col[i] == 0)
            {
                col[i] = 1;
                if (!Dfs(i))
                {
                    Console.WriteLine("impossible");
                    return;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (col[i] == 1)
            {
                Console.Write($"{item[i]} ");
            }
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            if (col[i] == 2)
            {
                Console.Write($"{item[i]} ");
            }
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8601
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Breaking Bad");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}