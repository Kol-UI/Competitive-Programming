// Find the Different Ones!
namespace CompetitiveProgramming.CodeForces.FindtheDifferentOnes;
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
            long[] v = new long[n + 1];

            long prev = 0;
            string[] vals = Console.ReadLine().Split();
            for (long p = 1; p <= n; p++)
            {
                long x = long.Parse(vals[p - 1]);
                if (x != prev) v[p] = p - 1;
                else v[p] = v[p - 1];
                prev = x;
            }

            long q = long.Parse(Console.ReadLine());
            while (q-- > 0)
            {
                string[] lr = Console.ReadLine().Split();
                long l = long.Parse(lr[0]);
                long r = long.Parse(lr[1]);
                if (v[r] < l) Console.WriteLine("-1 -1");
                else Console.WriteLine(v[r] + " " + r);
            }
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
        StyleHelper.Title("Find the Different Ones!");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}