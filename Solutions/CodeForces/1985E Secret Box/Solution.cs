// Secret Box
namespace CompetitiveProgramming.CodeForces.SecretBox;
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
            string[] input = Console.ReadLine().Split();
            long x = long.Parse(input[0]);
            long y = long.Parse(input[1]);
            long z = long.Parse(input[2]);
            long k = long.Parse(input[3]);
            
            long ans = 0;
            for (long a = 1; a <= x; a++)
            {
                for (long b = 1; b <= y; b++)
                {
                    if (k % (a * b) != 0) continue;
                    long c = k / (a * b);
                    if (c > z) continue;
                    long ways = (x - a + 1) * (y - b + 1) * (z - c + 1);
                    if (ways > ans) ans = ways;
                }
            }
            
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
        StyleHelper.Title("Secret Box");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}