// Hemose Shopping
namespace CompetitiveProgramming.CodeForces.HemoseShopping;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string[] nx = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(nx[0]);
            long x = long.Parse(nx[1]);

            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] a = new long[n];
            long[] b = new long[n];

            for (int p = 0; p < n; p++)
            {
                a[p] = long.Parse(parts[p]);
                b[p] = a[p];
            }

            if (2 * x <= n)
            {
                Console.WriteLine("YES");
                continue;
            }

            Array.Sort(b);
            bool possible = true;

            for (long p = n - x; possible && p < x; p++)
            {
                if (a[p] != b[p])
                {
                    possible = false;
                }
            }

            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hemose Shopping");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}