// Polycarp and Coins

namespace CompetitiveProgramming.CodeForces.PolycarpandCoins;

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    //public static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine()!);
            (int c1, int c2) = CalculateCoins(n);
            Console.WriteLine($"{c1} {c2}");
        }
    }

    private static (int, int) CalculateCoins(int n)
    {
        int c1 = n / 3;
        int c2 = n / 3;

        if (n % 3 == 1)
        {
            c1 += 1;
        }
        else if (n % 3 == 2)
        {
            c2 += 1;
        }

        return (c1, c2);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Polycarp and Coins");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}