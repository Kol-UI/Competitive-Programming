// Broken Calculator
namespace CompetitiveProgramming.Kattis.BrokenCalculator;
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
        long res = 1;
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            char op = char.Parse(input[1]);
            long b = long.Parse(input[2]);

            if (op == '+')
                res = a + b - res;
            else if (op == '-')
                res *= a - b;
            else if (op == '*')
                res = a * a * b * b;
            else if (op == '/')
                res = (a + 1) / 2;

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
        StyleHelper.Title("Broken Calculator");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}