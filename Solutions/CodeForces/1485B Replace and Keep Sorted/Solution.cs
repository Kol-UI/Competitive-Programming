// Replace and Keep Sorted
namespace CompetitiveProgramming.CodeForces.ReplaceandKeepSorted;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        long[] nqk = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long n = nqk[0];
        long q = nqk[1];
        long k = nqk[2];

        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

        while (q-- > 0)
        {
            long[] lr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long l = lr[0];
            long r = lr[1];

            long ans = k + (a[r - 1] - a[l - 1] + 1) - 2 * (r - l + 1);
            Console.WriteLine(ans);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Replace and Keep Sorted");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}