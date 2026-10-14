// Strong Vertices
namespace CompetitiveProgramming.CodeForces.StrongVertices;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            long[] a = new long[n];
            string[] aVals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) a[p] = long.Parse(aVals[p]);

            string[] bVals = Console.ReadLine().Split();
            (long, long)[] v = new (long, long)[n];
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(bVals[p]);
                v[p] = (a[p] - x, p + 1);
            }

            Array.Sort(v, (x, y) =>
            {
                int cmp = y.Item1.CompareTo(x.Item1);
                if (cmp != 0) return cmp;
                return y.Item2.CompareTo(x.Item2);
            });

            long cnt = 0;
            for (long p = 0; p < n; p++)
            {
                if (v[p].Item1 == v[0].Item1) cnt++;
                else break;
            }

            Console.WriteLine(cnt);
            for (long p = cnt - 1; p >= 0; p--)
                Console.Write(v[p].Item2 + " ");
            Console.WriteLine();
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
        StyleHelper.Title("Strong Vertices");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}