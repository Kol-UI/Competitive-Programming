// Diamond Miner
namespace CompetitiveProgramming.CodeForces.DiamondMiner;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Globalization;

internal class Program
{
    private static void Main()
    {
        if (!long.TryParse(Console.ReadLine(), out long t))
        {
            return;
        }

        while (t-- > 0)
        {
            long n = ReadNextLong();
            List<double> v = new();
            List<double> w = new();

            for (long p = 0; p < 2 * n; p++)
            {
                long x = ReadNextLong();
                long y = ReadNextLong();

                if (x < 0) x = -x;
                if (y < 0) y = -y;

                if (x != 0)
                {
                    v.Add(x);
                }
                else
                {
                    w.Add(y);
                }
            }

            v.Sort();
            w.Sort();

            double total = 0;
            for (int p = 0; p < n; p++)
            {
                total += Math.Sqrt(v[p] * v[p] + w[p] * w[p]);
            }

            Console.WriteLine(total.ToString("F11", CultureInfo.InvariantCulture));
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
        StyleHelper.Title("Diamond Miner");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}