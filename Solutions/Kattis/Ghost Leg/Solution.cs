// Ghost Leg
namespace CompetitiveProgramming.Kattis.GhostLeg;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        int[] pos = new int[n];
        for (int i = 0; i < n; i++)
            pos[i] = i;

        for (int i = 0; i < m; i++)
        {
            int a = int.Parse(Console.ReadLine()) - 1;
            int temp = pos[a];
            pos[a] = pos[a + 1];
            pos[a + 1] = temp;
        }

        foreach (int x in pos)
            Console.WriteLine(x + 1);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ghost Leg");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}

