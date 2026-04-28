// Rock and Lever
namespace CompetitiveProgramming.CodeForces.RockandLever;
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
            long[] v = new long[67];
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            long res = 0;
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                long cnt = 0;
                while (x > 1)
                {
                    x /= 2;
                    cnt++;
                }
                res += v[cnt];
                v[cnt]++;
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
        StyleHelper.Title("Rock and Lever");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}