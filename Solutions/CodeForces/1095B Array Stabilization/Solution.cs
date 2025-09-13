// Array Stabilization
namespace CompetitiveProgramming.CodeForces.ArrayStabilization;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        Array.Sort(a);
        long x = a[a.Length - 2] - a[0];
        long y = a[a.Length - 1] - a[1];
        Console.WriteLine(Math.Min(x, y));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Array Stabilization");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}