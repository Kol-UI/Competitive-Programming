// Simple Repetition
namespace CompetitiveProgramming.CodeForces.SimpleRepetition;
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
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long x = input[0], k = input[1];

            if (x == 1)
            {
                Console.WriteLine(k == 2 ? "Yes" : "No");
                continue;
            }
            else if (k > 1)
            {
                Console.WriteLine("No");
                continue;
            }

            bool ans = true;
            for (long p = 2; p * p <= x; p++)
            {
                if (x % p != 0) continue;
                ans = false;
                break;
            }

            Console.WriteLine(ans ? "Yes" : "No");
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
        StyleHelper.Title("Simple Repetition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}