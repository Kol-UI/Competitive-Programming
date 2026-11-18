// Cups and Balls
namespace CompetitiveProgramming.Kattis.CupsandBalls;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int g = int.Parse(Console.ReadLine()) - 1;
        int n = int.Parse(Console.ReadLine());

        int[] bloc = new int[] { 0, 1, 0 };
        for (int i = 0; i < n; i++)
        {
            string[] ab = Console.ReadLine().Split();
            int a = int.Parse(ab[0]) - 1;
            int b = int.Parse(ab[1]) - 1;
            int tmp = bloc[a];
            bloc[a] = bloc[b];
            bloc[b] = tmp;
        }

        if (bloc[g] == 1)
        {
            int a = Array.IndexOf(bloc, 0) + 1;
            int b = Array.IndexOf(bloc, 0, a) + 1;
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine((g + 1) + " " + (Array.IndexOf(bloc, 1) + 1));
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
        StyleHelper.Title("Cups and Balls");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}