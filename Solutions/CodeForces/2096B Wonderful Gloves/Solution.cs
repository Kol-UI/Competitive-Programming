// Wonderful Gloves
namespace CompetitiveProgramming.CodeForces.WonderfulGloves;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);

            string[] vlInput = Console.ReadLine().Split();
            string[] vrInput = Console.ReadLine().Split();

            long[] vl = new long[n];
            long[] vr = new long[n];
            List<long> v = new List<long>();

            long total = 0;

            for (long p = 0; p < n; p++)
            {
                vl[p] = long.Parse(vlInput[p]);
                vr[p] = long.Parse(vrInput[p]);
                long minVal = (vl[p] < vr[p]) ? vl[p] : vr[p];
                v.Add(minVal);
                total += vl[p] + vr[p];
            }

            v.Sort();

            for (long p = 0; p < n - k; p++)
                total -= v[(int)p];

            total -= (v[(int)(n - k)] - 1);

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
        StyleHelper.Title("Wonderful Gloves");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
