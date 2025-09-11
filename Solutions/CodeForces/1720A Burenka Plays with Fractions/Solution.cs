// Burenka Plays with Fractions
namespace CompetitiveProgramming.CodeForces.BurenkaPlayswithFractions;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long c = long.Parse(input[2]);
            long d = long.Parse(input[3]);
            long left = b * c;
            long right = a * d;
            if (left == right) Console.WriteLine("0");
            else if (left == 0 || right == 0) Console.WriteLine("1");
            else if (left % right == 0 || right % left == 0) Console.WriteLine("1");
            else Console.WriteLine("2");
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
        StyleHelper.Title("Burenka Plays with Fractions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}