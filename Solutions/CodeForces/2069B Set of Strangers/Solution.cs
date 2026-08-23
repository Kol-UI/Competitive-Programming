// Set of Strangers
namespace CompetitiveProgramming.CodeForces.SetofStrangers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

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

            long[][] f = new long[n][];
            HashSet<long> sa = new HashSet<long>();
            HashSet<long> sb = new HashSet<long>();

            for (long row = 0; row < n; row++)
            {
                f[row] = new long[m];
                string[] input = Console.ReadLine().Split();
                for (long col = 0; col < m; col++)
                {
                    f[row][col] = long.Parse(input[col]);
                    sa.Add(f[row][col]);

                    if (row > 0 && f[row - 1][col] == f[row][col])
                        sb.Add(f[row][col]);
                    if (col > 0 && f[row][col - 1] == f[row][col])
                        sb.Add(f[row][col]);
                }
            }

            long result = sa.Count + sb.Count - (sb.Count > 0 ? 1 : 0) - 1;
            Console.WriteLine(result);
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
        StyleHelper.Title("Set of Strangers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}