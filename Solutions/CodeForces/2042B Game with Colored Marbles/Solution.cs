// Game with Colored Marbles
namespace CompetitiveProgramming.CodeForces.GamewithColoredMarbles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Dictionary<long, long> m = new Dictionary<long, long>();
            foreach (long x in arr)
            {
                if (!m.ContainsKey(x)) m[x] = 0;
                m[x]++;
            }
            long ones = 0, more = 0;
            foreach (var kvp in m)
            {
                if (kvp.Value == 1) ones++;
                else more++;
            }
            Console.WriteLine(2 * ((ones + 1) / 2) + more);
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
        StyleHelper.Title("Game with Colored Marbles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}