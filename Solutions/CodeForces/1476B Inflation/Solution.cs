// Inflation
namespace CompetitiveProgramming.CodeForces.Inflation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static long[] ReadLongs(long count)
    {
        var result = new List<long>();
        while (result.Count < count)
        {
            string line = Console.ReadLine();
            if (line == null) break;
            foreach (var tok in line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))
                result.Add(long.Parse(tok));
        }
        return result.ToArray();
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long k = long.Parse(first[1]);

            long[] a = ReadLongs(n);

            long cs = a[0], res = 0;
            for (long p = 1; p < n; p++)
            {
                long x = a[p];
                if (100 * x > k * (cs + res))
                    res = (100 * x - k * cs + (k - 1)) / k;
                cs += x;
            }

            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Inflation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}