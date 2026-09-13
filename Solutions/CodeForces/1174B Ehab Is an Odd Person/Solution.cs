// Ehab Is an Odd Person
namespace CompetitiveProgramming.CodeForces.EhabIsanOddPerson;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        long n = long.Parse(nLine.Trim());
        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        long[] a = new long[n];
        bool odd = false;
        bool even = false;

        for (int p = 0; p < n; p++)
        {
            a[p] = long.Parse(parts[p]);
            if (a[p] % 2 != 0) odd = true;
            else even = true;
        }

        if (even && odd)
        {
            Array.Sort(a);
        }

        Console.WriteLine(string.Join(" ", a));
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ehab Is an Odd Person");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}