// Good Array
namespace CompetitiveProgramming.CodeForces.GoodArray;
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
        (long, long)[] a = new (long, long)[n];
        long sum = 0;

        string[] vals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++)
        {
            a[p] = (long.Parse(vals[p]), p);
            sum += a[p].Item1;
        }

        Array.Sort(a, (x, y) => x.Item1.CompareTo(y.Item1));

        List<long> ids = new List<long>();
        for (long p = 0; p < n; p++)
        {
            if (p + 1 < n && sum - a[p].Item1 == 2 * a[n - 1].Item1)
                ids.Add(1 + a[p].Item2);
            else if (p == n - 1 && sum - a[n - 1].Item1 == 2 * a[n - 2].Item1)
                ids.Add(1 + a[p].Item2);
        }

        Console.WriteLine(ids.Count);
        Console.WriteLine(string.Join(" ", ids));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Title");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}