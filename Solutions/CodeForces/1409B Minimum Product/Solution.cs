// Minimum Product
namespace CompetitiveProgramming.CodeForces.MinimumProduct;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static long Minimum(long a, long b, long x, long y, long n)
    {
        long dif = a - x;
        long mn = Math.Min(dif, n);
        a -= mn;
        n -= mn;
        dif = b - y;
        mn = Math.Min(dif, n);
        b -= mn;
        return a * b;
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long a = input[0], b = input[1], x = input[2], y = input[3], n = input[4];
            Console.WriteLine(Math.Min(Minimum(a, b, x, y, n), Minimum(b, a, y, x, n)));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Product");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}