// The Corridor or There and Back Again
namespace CompetitiveProgramming.CodeForces.TheCorridororThereandBackAgain;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long res = 1000000007;
            for (long p = 0; p < n; p++)
            {
                var ds = Console.ReadLine().Split().Select(long.Parse).ToList();
                long d = ds[0];
                long s = ds[1];
                long lim = d + (s - 1) / 2;
                res = Math.Min(res, lim);
            }
            Console.WriteLine(res);
        }
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
        StyleHelper.Title("The Corridor or There and Back Again");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}