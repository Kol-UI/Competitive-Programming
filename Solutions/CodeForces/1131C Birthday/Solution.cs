// Birthday
namespace CompetitiveProgramming.CodeForces.Birthday;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        int n = int.Parse(nLine.Trim());
        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        long[] a = new long[n];
        for (int p = 0; p < n; p++)
        {
            a[p] = long.Parse(parts[p]);
        }

        Array.Sort(a);

        List<long> res = new List<long>();
        for (int p = 0; p < n; p += 2)
        {
            res.Add(a[p]);
        }
        for (int p = n - 1 - (n % 2); p >= 1; p -= 2)
        {
            res.Add(a[p]);
        }

        Console.WriteLine(string.Join(" ", res));
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Birthday");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}