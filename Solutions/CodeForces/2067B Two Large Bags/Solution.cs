// Two Large Bags
namespace CompetitiveProgramming.CodeForces.TwoLargeBags;
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
            long[] v = new long[n + 2];
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                v[x]++;
            }
            
            bool ans = (n % 2 == 0);
            for (long p = 1; ans && p <= n; p++)
            {
                if (v[p] == 0) continue;
                if (v[p] == 1)
                {
                    ans = false;
                }
                else if (p < n)
                {
                    v[p + 1] += v[p] - 2;
                }
            }
            
            if (v[n] % 2 == 1) ans = false;
            
            Console.WriteLine(ans ? "Yes" : "No");
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
        StyleHelper.Title("Two Large Bags");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}