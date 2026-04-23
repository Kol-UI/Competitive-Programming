// Bestie
namespace CompetitiveProgramming.CodeForces.Bestie;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            long g = 0;
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                g = Gcd(g, x);
            }
            
            if (g == 1)
            {
                Console.WriteLine("0");
            }
            else if (Gcd(g, n) == 1)
            {
                Console.WriteLine("1");
            }
            else if (Gcd(g, n - 1) == 1)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
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
        StyleHelper.Title("Bestie");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}