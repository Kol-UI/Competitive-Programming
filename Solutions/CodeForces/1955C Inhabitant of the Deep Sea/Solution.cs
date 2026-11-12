// Inhabitant of the Deep Sea
namespace CompetitiveProgramming.CodeForces.InhabitantoftheDeepSea;
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
            long k = long.Parse(first[1]);

            LinkedList<long> dq = new LinkedList<long>();
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
                dq.AddLast(long.Parse(vals[p]));

            while (k > 0 && dq.Count > 1)
            {
                long front = dq.First.Value;
                long back = dq.Last.Value;
                long mn = front < back ? front : back;
                long rem = k < 2 * mn ? k : 2 * mn;

                dq.First.Value -= (rem + 1) / 2;
                dq.Last.Value -= rem / 2;

                if (dq.First.Value == 0) dq.RemoveFirst();
                if (dq.Count > 0 && dq.Last.Value == 0) dq.RemoveLast();

                k -= rem;
            }

            if (dq.Count > 0)
            {
                dq.First.Value -= k;
                if (dq.First.Value <= 0) dq.RemoveFirst();
            }

            Console.WriteLine(n - dq.Count);
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
        StyleHelper.Title("Inhabitant of the Deep Sea");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}