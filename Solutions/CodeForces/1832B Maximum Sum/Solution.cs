// Maximum Sum
namespace CompetitiveProgramming.CodeForces.MaximumSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] nk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nk[0], k = nk[1];
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Sort(a);
            long[] b = new long[n];
            b[0] = a[0];
            for (int p = 1; p < n; p++) b[p] = b[p - 1] + a[p];

            long total = b[n - 1 - (int)k];
            for (int p = 1; p <= k; p++)
            {
                long tst = b[n - 1 - (int)k + p] - b[2 * p - 1];
                total = Math.Max(total, tst);
            }

            Console.WriteLine(total);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}