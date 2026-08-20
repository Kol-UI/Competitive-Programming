// Getting Points
namespace CompetitiveProgramming.CodeForces.GettingPoints;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long P = long.Parse(input[1]);
            long l = long.Parse(input[2]);
            long s = long.Parse(input[3]);
            long ns = (n + 6) / 7;
            long a = (P + l + 2 * s - 1) / (l + 2 * s);
            long b = (P - s * ns + l - 1) / l;
            long res = n - (a > b ? a : b);
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
        StyleHelper.Title("Getting Points");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
