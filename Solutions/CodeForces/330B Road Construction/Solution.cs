// Road Construction
namespace CompetitiveProgramming.CodeForces.RoadConstruction;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        bool[] nodes = new bool[n + 1];
        for (int k = 1; k <= n; k++) nodes[k] = true;

        for (int k = 0; k < m; k++)
        {
            string[] ab = Console.ReadLine().Split();
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            nodes[a] = false;
            nodes[b] = false;
        }

        int central = 0;
        for (int k = 1; k <= n; k++)
        {
            if (nodes[k]) { central = k; break; }
        }

        Console.WriteLine(n - 1);
        for (int k = 1; k <= n; k++)
        {
            if (k == central) continue;
            Console.WriteLine(central + " " + k);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Road Construction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}