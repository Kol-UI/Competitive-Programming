// Ehab Fails to Be Thanos
namespace CompetitiveProgramming.CodeForces.EhabFailstoBeThanos;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Solution
{
    static void Main(string[] args)
    {
        string line1 = Console.ReadLine()!;
        if (line1 == null) return;

        long n = long.Parse(line1);
        n *= 2;

        string[] inputs = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
        List<long> a = new List<long>();

        for (int p = 0; p < n; p++)
        {
            a.Add(long.Parse(inputs[p]));
        }

        a.Sort();

        if (a[0] == a[a.Count - 1])
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(string.Join(" ", a));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ehab Fails to Be Thanos");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}