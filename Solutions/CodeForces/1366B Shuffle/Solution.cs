// Shuffle
namespace CompetitiveProgramming.CodeForces.Shuffle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long x = long.Parse(first[1]);
            long m = long.Parse(first[2]);

            long left = x, right = x;
            while (m-- > 0)
            {
                string[] lr = Console.ReadLine().Split();
                long ll = long.Parse(lr[0]);
                long rr = long.Parse(lr[1]);
                if (rr < left || right < ll) continue;
                if (ll < left) left = ll;
                if (rr > right) right = rr;
            }

            Console.WriteLine(right - left + 1);
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
        StyleHelper.Title("Shuffle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}