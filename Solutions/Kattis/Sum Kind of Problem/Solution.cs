// Sum Kind of Problem
namespace CompetitiveProgramming.Kattis.SumKindofProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static int S1(int n)
    {
        int total = 0;
        for (int i = 0; i <= n; i++)
        {
            total += i;
        }
        return total;
    }

    static int S2(int n)
    {
        int total = 0;
        for (int i = 1; i < 2 * n; i += 2)
        {
            total += i;
        }
        return total;
    }

    static int S3(int n)
    {
        int total = 0;
        for (int i = 0; i < 2 * n + 1; i += 2)
        {
            total += i;
        }
        return total;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int temp1 = int.Parse(input[0]);
            int temp2 = int.Parse(input[1]);

            Console.WriteLine($"{i + 1} {S1(temp2)} {S2(temp2)} {S3(temp2)}");
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
        StyleHelper.Title("Sum Kind of Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}