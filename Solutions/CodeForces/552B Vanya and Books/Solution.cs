// Vanya and Books
namespace CompetitiveProgramming.CodeForces.VanyaandBooks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        long n = long.Parse(input.Trim());
        long d = 1, start = 1, end = 10, total = 0;

        while (start <= n)
        {
            if (n < end) { end = n + 1; }
            total += d * (end - start);
            start = end;
            end *= 10;
            ++d;
        }

        Console.WriteLine(total);
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vanya and Books");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}