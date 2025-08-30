// Chips Moving
namespace CompetitiveProgramming.CodeForces.ChipsMoving;
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
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long cnt = 0;
        foreach (long x in arr) cnt += x % 2;
        Console.WriteLine(2 * cnt < n ? cnt : n - cnt);
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
        StyleHelper.Title("Chips Moving");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}