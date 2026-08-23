// Large Array and Segments
namespace CompetitiveProgramming.CodeForces.LargeArrayandSegments;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);
            long x = long.Parse(firstLine[2]);

            string[] input = Console.ReadLine().Split();
            long[] a = new long[n];
            long s = 0;

            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(input[p]);
                s += a[p];
            }

            long cnt = n * k;
            cnt -= (x / s) * n;
            x %= s;
            if (x == 0) cnt++;

            for (long p = n - 1; x > 0 && cnt > 0 && p >= 0; p--)
            {
                x -= a[p];
                if (x <= 0) break;
                cnt--;
            }

            if (cnt < 0) cnt = 0;
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Large Array and Segments");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}