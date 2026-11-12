// Triple Operations
namespace CompetitiveProgramming.CodeForces.TripleOperations;
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
        long size = 200007;
        long[] v = new long[size];

        for (long p = 1; p < size; p++)
            v[p] = 1 + v[p / 3];
        for (long p = 1; p < size; p++)
            v[p] += v[p - 1];

        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            long a = long.Parse(first[0]);
            long b = long.Parse(first[1]);

            long res = v[b] - 2 * v[a - 1] + v[a];
            Console.WriteLine(res);
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
        StyleHelper.Title("Triple Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}