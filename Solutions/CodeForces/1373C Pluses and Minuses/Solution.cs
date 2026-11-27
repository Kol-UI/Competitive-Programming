// Pluses and Minuses
namespace CompetitiveProgramming.CodeForces.PlusesandMinuses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            long cur = 0, add = 0, res = s.Length;

            for (long p = 0; p < s.Length; p++)
            {
                cur += (s[(int)p] == '+' ? 1 : 0) - (s[(int)p] == '-' ? 1 : 0);
                if (add + cur < 0)
                {
                    res += (p + 1);
                    add++;
                }
            }

            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pluses and Minuses");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}