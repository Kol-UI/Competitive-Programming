// Fibonacci Cubes
namespace CompetitiveProgramming.CodeForces.FibonacciCubes;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);

            long f = 1;
            long g = 1;

            for (long p = 2; p <= n + 1; p++)
            {
                long x = f;
                f = g;
                g += x;
            }

            char[] s = new char[m];
            for (int i = 0; i < m; i++)
                s[i] = '0';

            for (long p = 0; p < m; p++)
            {
                string[] input = Console.ReadLine().Split();
                long a = long.Parse(input[0]);
                long b = long.Parse(input[1]);
                long c = long.Parse(input[2]);

                long d = (a > b) ? a : b;
                if (c > d) d = c;

                if (a >= f && b >= f && c >= f && d >= g)
                    s[p] = '1';
            }

            Console.WriteLine(new string(s));
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
        StyleHelper.Title("Fibonacci Cubes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}