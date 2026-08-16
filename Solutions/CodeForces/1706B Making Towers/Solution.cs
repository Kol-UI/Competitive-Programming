// Making Towers
namespace CompetitiveProgramming.CodeForces.MakingTowers;
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
            string[] input = Console.ReadLine().Split();

            long[] last = new long[n + 1];
            long[] cnt = new long[n + 1];
            long[] height = new long[n + 1];

            for (long i = 0; i <= n; i++)
            {
                last[i] = -1;
                cnt[i] = 0;
                height[i] = 0;
            }

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (last[x] < 0 || (p - last[x]) % 2 == 1)
                {
                    cnt[x]++;
                    if (cnt[x] > height[x]) height[x] = cnt[x];
                    last[x] = p;
                }
            }

            for (long p = 1; p <= n; p++)
            {
                Console.Write($"{height[p]} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("Making Towers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
