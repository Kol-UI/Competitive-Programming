// Product of Binary Decimals
namespace CompetitiveProgramming.CodeForces.ProductofBinaryDecimals;
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
    static bool IsBinary(long x)
    {
        while (x > 0)
        {
            if (x % 10 > 1) return false;
            x /= 10;
        }
        return true;
    }

    //static void Main()
    public static void MainSolution()
    {
        const int size = 100007;
        bool[] v = new bool[size];
        v[1] = true;

        for (int p = 1; p < size; p++)
            v[p] = IsBinary(p);

        for (int p = 1; p < size; p++)
        {
            if (!v[p]) continue;
            for (int q = 1; q <= p && q * p < size; q++)
                if (v[q]) v[p * q] = true;
        }

        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(v[n] ? "YES" : "NO");
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
        StyleHelper.Title("Title");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}