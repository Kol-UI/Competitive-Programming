// Non-coprime Split
namespace CompetitiveProgramming.CodeForces.NoncoprimeSplit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] lr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long l = lr[0], r = lr[1];

            if (r < 4)
            {
                Console.WriteLine("-1");
            }
            else if (l == r)
            {
                long first = -1;
                for (long p = 2; p * p <= r; p++)
                {
                    if ((r - p) % p == 0)
                    {
                        first = p;
                        break;
                    }
                }
                Console.WriteLine(first > 0 ? $"{first} {r - first}" : "-1");
            }
            else
            {
                Console.WriteLine($"2 {r - r % 2 - 2}");
            }
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
        StyleHelper.Title("Non-coprime Split");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}