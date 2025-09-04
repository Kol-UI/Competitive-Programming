// Also Try Minecraft
namespace CompetitiveProgramming.CodeForces.AlsoTryMinecraft;
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
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);
        long[] h = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long[] left = new long[n];
        for (long p = 1; p < n; p++)
        {
            left[p] = left[p - 1] + (h[p] < h[p - 1] ? h[p - 1] - h[p] : 0);
        }
        long[] right = new long[n];
        for (long p = n - 2; p >= 0; p--)
        {
            right[p] = right[p + 1] + (h[p] < h[p + 1] ? h[p + 1] - h[p] : 0);
        }
        while (m-- > 0)
        {
            string[] query = Console.ReadLine().Split();
            long s = long.Parse(query[0]);
            long f = long.Parse(query[1]);
            long res;
            if (f > s) res = left[f - 1] - left[s - 1];
            else res = right[f - 1] - right[s - 1];
            Console.WriteLine(res);
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
        StyleHelper.Title("Also Try Minecraft");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}