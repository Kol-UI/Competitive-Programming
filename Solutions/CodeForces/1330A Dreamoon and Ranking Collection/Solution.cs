// Dreamoon and Ranking Collection
namespace CompetitiveProgramming.CodeForces.DreamoonandRankingCollection;
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
        const int N = 207;
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long x = long.Parse(input[1]);
            bool[] b = new bool[N];
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long a in arr) if (a < N) b[a] = true;
            long res = 0;
            for (int p = 1; p < N; p++)
            {
                if (b[p]) continue;
                if (x > 0) x--;
                else
                {
                    res = p - 1;
                    break;
                }
            }
            Console.WriteLine(res);
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
        StyleHelper.Title("Dreamoon and Ranking Collection");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}