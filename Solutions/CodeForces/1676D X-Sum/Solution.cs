// X-Sum
namespace CompetitiveProgramming.CodeForces.XSum;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0], m = nm[1];
            long[,] f = new long[n, m];
            Dictionary<long, long> s = new Dictionary<long, long>();
            Dictionary<long, long> d = new Dictionary<long, long>();

            for (int row = 0; row < n; row++)
            {
                long[] rowValues = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                for (int col = 0; col < m; col++)
                {
                    f[row, col] = rowValues[col];
                    long key1 = row + col;
                    if (s.ContainsKey(key1)) s[key1] += f[row, col];
                    else s[key1] = f[row, col];
                    long key2 = row - col;
                    if (d.ContainsKey(key2)) d[key2] += f[row, col];
                    else d[key2] = f[row, col];
                }
            }

            long res = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    long cand = s[row + col] + d[row - col] - f[row, col];
                    res = Math.Max(res, cand);
                }
            }

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
        StyleHelper.Title("X-Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}