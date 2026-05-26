// Shattered Cake
namespace CompetitiveProgramming.Kattis.ShatteredCake;
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
        long n = long.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        long area = 0;
        for (int i = 0; i < m; i++)
        {
            string[] input = Console.ReadLine().Split();
            long w = long.Parse(input[0]);
            long h = long.Parse(input[1]);
            area += w * h;
        }

        Console.WriteLine(area / n);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shattered Cake");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}