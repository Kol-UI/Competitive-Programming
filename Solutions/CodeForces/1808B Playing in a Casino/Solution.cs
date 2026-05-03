// Playing in a Casino
namespace CompetitiveProgramming.CodeForces.PlayinginaCasino;
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
            
            long[][] f = new long[n][];
            for (long row = 0; row < n; row++)
            {
                f[row] = new long[m];
                string[] rowInput = Console.ReadLine().Split();
                for (long col = 0; col < m; col++)
                {
                    f[row][col] = long.Parse(rowInput[col]);
                }
            }
            
            long total = 0;
            for (int col = 0; col < m; col++)
            {
                long[] v = new long[n];
                for (long row = 0; row < n; row++)
                {
                    v[row] = f[row][col];
                }
                Array.Sort(v);
                for (long p = 0; p < n; p++)
                {
                    total += (2 * p - (n - 1)) * v[p];
                }
            }
            
            Console.WriteLine(total);
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
        StyleHelper.Title("Playing in a Casino");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}