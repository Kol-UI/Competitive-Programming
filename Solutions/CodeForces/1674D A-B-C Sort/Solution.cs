// A-B-C Sort
namespace CompetitiveProgramming.CodeForces.ABCSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        long t = ReadNextLong();
        while (t-- > 0)
        {
            long n = ReadNextLong();
            List<long> a = new((int)n);
            for (long p = 0; p < n; p++)
            {
                a.Add(ReadNextLong());
            }

            for (long p = n - 2; p >= 0; p -= 2)
            {
                if (a[(int)p + 1] < a[(int)p])
                {
                    long x = a[(int)p];
                    a[(int)p] = a[(int)p + 1];
                    a[(int)p + 1] = x;
                }
            }

            bool sorted = true;
            for (int p = 1; sorted && p < n; p++)
            {
                if (a[p - 1] > a[p])
                {
                    sorted = false;
                }
            }

            Console.WriteLine(sorted ? "YES" : "NO");
        }
    }

    private static long ReadNextLong()
    {
        int ch;
        while ((ch = Console.Read()) != -1 && ch <= 32) ;

        if (ch == -1) return 0;

        long sign = 1;
        if (ch == '-')
        {
            sign = -1;
            ch = Console.Read();
        }

        long res = 0;
        while (ch >= '0' && ch <= '9')
        {
            res = res * 10 + (ch - '0');
            ch = Console.Read();
        }

        return res * sign;
    }
}
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A-B-C Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}