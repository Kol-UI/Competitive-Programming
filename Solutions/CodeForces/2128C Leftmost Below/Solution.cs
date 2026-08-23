// Leftmost Below
namespace CompetitiveProgramming.CodeForces.LeftmostBelow;
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
            
            long mn = 1000000007;
            bool ans = true;
            
            for (long p = 0; p < n; p++)
            {
                long b = long.Parse(input[p]);
                if (mn < b / 2 + 1)
                {
                    ans = false;
                }
                if (b < mn) mn = b;
            }
            
            Console.WriteLine(ans ? "YES" : "NO");
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
        StyleHelper.Title("Leftmost Below");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}