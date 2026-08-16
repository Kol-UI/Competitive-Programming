// Make It Ugly
namespace CompetitiveProgramming.CodeForces.MakeItUgly;
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
            
            long x = long.Parse(input[0]);
            long pos = -1;
            long ans = n + 7;
            
            for (long p = 1; p < n; p++)
            {
                long a = long.Parse(input[p]);
                if (a != x)
                {
                    if (p - 1 - pos < ans) ans = p - 1 - pos;
                    pos = p;
                }
            }
            
            if (n - 1 - pos < ans) ans = n - 1 - pos;
            
            if (ans >= n)
                Console.WriteLine("-1");
            else
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
        StyleHelper.Title("Make It Ugly");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}