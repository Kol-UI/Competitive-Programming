// Black Circles
namespace CompetitiveProgramming.CodeForces.BlackCircles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] x = new long[n];
            long[] y = new long[n];

            for (int p = 0; p < n; p++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                x[p] = long.Parse(parts[0]);
                y[p] = long.Parse(parts[1]);
            }

            string[] targetParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long xs = long.Parse(targetParts[0]);
            long ys = long.Parse(targetParts[1]);
            long xt = long.Parse(targetParts[2]);
            long yt = long.Parse(targetParts[3]);

            long dst = (xs - xt) * (xs - xt) + (ys - yt) * (ys - yt);
            bool possible = true;

            for (int p = 0; possible && p < n; p++)
            {
                long cdt = (x[p] - xt) * (x[p] - xt) + (y[p] - yt) * (y[p] - yt);
                if (cdt <= dst)
                {
                    possible = false;
                }
            }

            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Black Circles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}