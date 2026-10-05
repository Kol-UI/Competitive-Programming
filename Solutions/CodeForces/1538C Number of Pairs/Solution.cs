// Number of Pairs
namespace CompetitiveProgramming.CodeForces.NumberofPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static long F(long[] v, long s)
    {
        long left = 0, right = v.Length - 1;
        long res = 0;
        while (left < right)
        {
            if (v[left] + v[right] > s) right--;
            else { res += right - left; left++; }
        }
        return res;
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long lower = long.Parse(first[1]);
            long upper = long.Parse(first[2]);

            long[] a = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) a[p] = long.Parse(vals[p]);

            Array.Sort(a);
            long cnt = F(a, upper) - F(a, lower - 1);
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
        StyleHelper.Title("Number of Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}