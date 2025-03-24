// Ice Skating
namespace CompetitiveProgramming.CodeForces.IceSkating;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#nullable disable
using System;

class Program
{
    static int n;
    static int[,] g;
    static bool[] vis;

    static void Dfs(int x)
    {
        vis[x] = true;
        for (int i = 0; i < n; i++)
        {
            if (!vis[i] && (g[i, 0] == g[x, 0] || g[i, 1] == g[x, 1]))
            {
                Dfs(i);
            }
        }
    }

    //static void Main()
    public static void MainSolution()
    {
        n = int.Parse(Console.ReadLine()!);
        g = new int[n, 2];
        vis = new bool[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split();
            g[i, 0] = int.Parse(input[0]);
            g[i, 1] = int.Parse(input[1]);
        }

        int con = 0;
        for (int i = 0; i < n; i++)
        {
            if (!vis[i])
            {
                con++;
                Dfs(i);
            }
        }

        Console.WriteLine(con - 1);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ice Skating");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}
#nullable enable