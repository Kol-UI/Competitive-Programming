// Corners
namespace CompetitiveProgramming.CodeForces.Corners;
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
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(line[0]);
            long m = long.Parse(line[1]);

            List<string> v = new List<string>((int)n);
            for (long row = 0; row < n; row++)
            {
                v.Add(Console.ReadLine());
            }

            long ones = 0;
            for (long row = 0; row < n; row++)
            {
                for (long col = 0; col < m; col++)
                {
                    ones += v[(int)row][(int)col] - '0';
                }
            }

            long mn = 5;
            for (long row = 0; row < n - 1; row++)
            {
                for (long col = 0; col < m - 1; col++)
                {
                    long cur = v[(int)row][(int)col] + v[(int)row][(int)col + 1] + v[(int)row + 1][(int)col] + v[(int)row + 1][(int)col + 1] - 4 * '0';
                    if (cur == 0) continue;
                    long tst = (cur > 2) ? (cur - 1) : 1;
                    mn = (mn < tst) ? mn : tst;
                }
            }

            long ans = ones != 0 ? (1 + ones - mn) : 0;
            Console.WriteLine(ans);
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
        StyleHelper.Title("Corners");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}