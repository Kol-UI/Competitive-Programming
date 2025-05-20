// Indivisible
namespace CompetitiveProgramming.CodeForces.Indivisible;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);

            if (n == 1)
            {
                Console.WriteLine(1);
                continue;
            }

            if ((n * (n + 1) / 2) % n == 0)
            {
                Console.WriteLine(-1);
                continue;
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write((i + 2) + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Indivisible");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}