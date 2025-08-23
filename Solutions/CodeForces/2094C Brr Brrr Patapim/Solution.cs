// Brr Brrr Patapim
namespace CompetitiveProgramming.CodeForces.BrrBrrrPatapim;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            List<long> v = new List<long>(new long[2 * n + 1]);
            List<bool> w = new List<bool>(new bool[2 * n + 1]);
            for (int i = 0; i <= 2 * n; i++) w[i] = true;
            for (long row = 1; row <= n; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (long col = 1; col <= n; col++)
                {
                    long x = long.Parse(line[col - 1]);
                    w[(int)x] = false;
                    v[(int)(row + col)] = x;
                }
            }
            for (long p = 1; p <= 2 * n; p++)
            {
                if (w[(int)p])
                {
                    v[1] = p;
                    break;
                }
            }
            for (long p = 1; p <= 2 * n; p++) Console.Write(v[(int)p] + " ");
            Console.WriteLine();
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
        StyleHelper.Title("Brr Brrr Patapim");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}