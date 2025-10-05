// Subset Mex
namespace CompetitiveProgramming.CodeForces.SubsetMex;
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
        const int N = 107;
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] b = new long[N];
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in arr) if (x < N) b[x]++;
            bool empty = true;
            long s = 0;
            for (int p = 0; p < N; p++)
            {
                if (b[p] > 1) continue;
                else if (b[p] == 1 && empty)
                {
                    s = p;
                    empty = false;
                }
                else if (b[p] == 0)
                {
                    s += (empty ? 2 : 1) * p;
                    break;
                }
            }
            Console.WriteLine(s);
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
        StyleHelper.Title("Subset Mex");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}