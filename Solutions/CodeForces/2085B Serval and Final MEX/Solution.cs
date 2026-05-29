// Serval and Final MEX
namespace CompetitiveProgramming.CodeForces.ServalandFinalMEX;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            
            long first = 0;
            long last = 0;
            
            for (long p = 1; p <= n; p++)
            {
                long x = long.Parse(input[p - 1]);
                if (x != 0) continue;
                if (first == 0) first = p;
                last = p;
            }
            
            if (last == 0)
            {
                Console.WriteLine($"1\n1 {n}");
            }
            else if (first == 1 && last == n)
            {
                Console.WriteLine($"3\n3 {n}\n1 2\n1 2");
            }
            else if (last != n)
            {
                Console.WriteLine($"2\n1 {n - 1}\n1 2");
            }
            else if (first != 1)
            {
                Console.WriteLine($"2\n2 {n}\n1 2");
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
        StyleHelper.Title("Serval and Final MEX");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}