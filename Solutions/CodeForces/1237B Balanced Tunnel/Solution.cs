// Balanced Tunnel
namespace CompetitiveProgramming.CodeForces.BalancedTunnel;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long[] a = new long[n];
        string[] aVals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++) a[p] = long.Parse(aVals[p]);

        long[] b = new long[n];
        string[] bVals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++) b[p] = long.Parse(bVals[p]);

        HashSet<long> s = new HashSet<long>();
        long ind = 0, cnt = 0;

        for (long p = 0; p < n; p++)
        {
            while (ind < n && s.Contains(a[ind])) ind++;
            if (ind < n && b[p] != a[ind]) cnt++;
            s.Add(b[p]);
        }

        Console.WriteLine(cnt);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Balanced Tunnel");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}