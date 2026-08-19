// Lamps
namespace CompetitiveProgramming.CodeForces.Lamps;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool Cmp((long, long) a, (long, long) b)
    {
        if (a.Item1 != b.Item1)
            return a.Item1 < b.Item1;
        return a.Item2 > b.Item2;
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            List<(long, long)> v = new List<(long, long)>();

            for (long p = 0; p < n; p++)
            {
                string[] input = Console.ReadLine().Split();
                v.Add((long.Parse(input[0]), long.Parse(input[1])));
            }

            v.Sort((a, b) =>
            {
                if (a.Item1 != b.Item1)
                    return a.Item1.CompareTo(b.Item1);
                return b.Item2.CompareTo(a.Item2);
            });

            long idx = 0;
            long cnt = 0;
            long total = 0;

            for (long p = 0; p < n; p++)
            {
                if (p < idx) continue;

                total += v[(int)p].Item2;
                cnt++;

                while (idx < n && v[(int)idx].Item1 <= cnt)
                    idx++;

                cnt = p - idx + 1;
                if (cnt < 0) cnt = 0;
            }

            Console.WriteLine(total);
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
        StyleHelper.Title("Lamps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
