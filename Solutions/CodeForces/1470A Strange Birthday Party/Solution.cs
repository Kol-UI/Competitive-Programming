// Strange Birthday Party
namespace CompetitiveProgramming.CodeForces.StrangeBirthdayParty;
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
            long m = long.Parse(first[1]);

            long[] kv = new long[n];
            string[] kvVals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) kv[p] = long.Parse(kvVals[p]) - 1;

            Array.Sort(kv);
            Array.Reverse(kv);

            long[] c = new long[m];
            string[] cVals = Console.ReadLine().Split();
            for (long p = 0; p < m; p++) c[p] = long.Parse(cVals[p]);

            long res = 0;
            for (long p = 0; p < n; p++)
            {
                long idx = (p < kv[p]) ? p : kv[p];
                res += c[idx];
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
        StyleHelper.Title("Strange Birthday Party");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}