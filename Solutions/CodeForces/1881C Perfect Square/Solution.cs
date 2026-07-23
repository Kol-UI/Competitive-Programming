// Perfect Square
namespace CompetitiveProgramming.CodeForces.PerfectSquare;
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
            long n = long.Parse(Console.ReadLine());
            char[][] m = new char[n][];
            for (long row = 0; row < n; row++)
            {
                m[row] = Console.ReadLine().ToCharArray();
            }

            long cnt = 0;
            for (long row = 0; row < n; row++)
            {
                for (long col = 0; col < n; col++)
                {
                    char w = m[row][col];
                    char x = m[col][n - 1 - row];
                    char y = m[n - 1 - row][n - 1 - col];
                    char z = m[n - 1 - col][row];

                    char f = (w > x) ? w : x;
                    f = (f > y) ? f : y;
                    f = (f > z) ? f : z;

                    m[row][col] = f;
                    m[col][n - 1 - row] = f;
                    m[n - 1 - row][n - 1 - col] = f;
                    m[n - 1 - col][row] = f;

                    cnt += (f - w) + (f - x) + (f - y) + (f - z);
                }
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Perfect Square");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}