// Maximums
namespace CompetitiveProgramming.CodeForces.Maximums;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long n = long.Parse(Console.ReadLine());
        long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long mx = 0;
        for (long p = 0; p < n; p++)
        {
            long a = b[p] + mx;
            Console.Write(a + " ");
            mx = Math.Max(mx, a);
        }
        Console.WriteLine();
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
        StyleHelper.Title("Maximums");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}