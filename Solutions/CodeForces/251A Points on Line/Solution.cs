// Points on Line
namespace CompetitiveProgramming.CodeForces.PointsonLine;
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
        string[] first = Console.ReadLine().Split();
        long n = long.Parse(first[0]);
        long d = long.Parse(first[1]);

        long[] array = new long[n];
        string[] vals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++) array[p] = long.Parse(vals[p]);

        long total = 0;
        long right = 0;

        for (long left = 0; left < n - 1; left++)
        {
            while (right < n && array[right] <= array[left] + d) right++;
            right--;
            long numPoints = right - left;
            total += numPoints * (numPoints - 1) / 2;
        }

        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Points on Line");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}