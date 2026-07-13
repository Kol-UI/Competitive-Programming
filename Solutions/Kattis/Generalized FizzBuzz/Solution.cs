// Generalized FizzBuzz
namespace CompetitiveProgramming.Kattis.GeneralizedFizzBuzz;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long a = long.Parse(input[1]);
        long b = long.Parse(input[2]);

        long ab = a * b / Gcd(a, b);

        long fi = 0, bu = 0, fibu = 0;

        for (long i = 1; i <= n; i++)
        {
            if (i % ab == 0)
                fibu++;
            else if (i % a == 0)
                fi++;
            else if (i % b == 0)
                bu++;
        }

        Console.WriteLine($"{fi} {bu} {fibu}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Generalized FizzBuzz");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}