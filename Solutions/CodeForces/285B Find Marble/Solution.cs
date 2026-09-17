// Find Marble
namespace CompetitiveProgramming.CodeForces.FindMarble;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] nst = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(nst[0]);
        int s = int.Parse(nst[1]);
        int t = int.Parse(nst[2]);

        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] p = new int[n + 1];
        for (int k = 1; k <= n; k++)
        {
            p[k] = int.Parse(parts[k - 1]);
        }

        int pos = s, swaps = 0;
        for (int k = 0; k < n; k++)
        {
            if (pos == t) { break; }
            else { pos = p[pos]; swaps++; }
        }

        if (pos != t) { swaps = -1; }
        Console.WriteLine(swaps);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Marble");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}