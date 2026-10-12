// Queries about less or equal elements
namespace CompetitiveProgramming.CodeForces.Queriesaboutlessorequalelements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        long[] a = new long[n];
        string[] aVals = Console.ReadLine().Split();
        for (int p = 0; p < n; p++) a[p] = long.Parse(aVals[p]);

        long[] b = new long[m];
        string[] bVals = Console.ReadLine().Split();
        for (int p = 0; p < m; p++) b[p] = long.Parse(bVals[p]);

        Array.Sort(a);

        for (int p = 0; p < m; p++)
        {
            int lo = 0, hi = n;
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (a[mid] <= b[p]) lo = mid + 1;
                else hi = mid;
            }
            Console.Write(lo + " ");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Queries about less or equal elements");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}