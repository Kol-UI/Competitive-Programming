// Cracking RSA
namespace CompetitiveProgramming.Kattis.CrackingRSA;
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
        int t = int.Parse(Console.ReadLine());

        for (int idx = 0; idx < t; idx++)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long e = long.Parse(input[1]);

            long p = 0;
            for (long i = 2; i < 1000; i++)
            {
                if (n % i == 0)
                {
                    p = i;
                    break;
                }
            }

            long q = n / p;
            long phi = (p - 1) * (q - 1);

            long d = ModInverse(e, phi);
            Console.WriteLine(d);
        }
    }

    static long ModInverse(long a, long m)
    {
        long m0 = m;
        long y = 0;
        long x = 1;

        if (m == 1)
            return 0;

        while (a > 1)
        {
            long q = a / m;
            long t = m;

            m = a % m;
            a = t;
            t = y;

            y = x - q * y;
            x = t;
        }

        if (x < 0)
            x += m0;

        return x;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cracking RSA");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}