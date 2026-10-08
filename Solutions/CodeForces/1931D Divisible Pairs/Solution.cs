// Divisible Pairs
namespace CompetitiveProgramming.CodeForces.DivisiblePairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

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
            long y = long.Parse(first[2]);

            var mods = new Dictionary<(long, long), HashSet<long>>();

            long cnt = 0;
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long a = long.Parse(vals[p]);
                var key = ((x - (a % x)) % x, a % y);
                if (mods.ContainsKey(key)) cnt += mods[key].Count;

                var ownKey = (a % x, a % y);
                if (!mods.ContainsKey(ownKey)) mods[ownKey] = new HashSet<long>();
                mods[ownKey].Add(p);
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Divisible Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}