// Game 23
namespace CompetitiveProgramming.CodeForces.Game23;
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
        long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long n = input[0], m = input[1];
        
        if (m % n != 0)
        {
            Console.WriteLine("-1");
            return;
        }

        long d = m / n;
        long cnt = 0;

        while (d % 2 == 0) { d /= 2; ++cnt; }
        while (d % 3 == 0) { d /= 3; ++cnt; }

        Console.WriteLine(d == 1 ? cnt : -1);
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
        StyleHelper.Title("Game 23");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}