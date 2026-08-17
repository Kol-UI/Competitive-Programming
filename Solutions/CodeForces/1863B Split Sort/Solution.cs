// Split Sort
namespace CompetitiveProgramming.CodeForces.SplitSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            List<(long value, long index)> v = new List<(long, long)>();
            for (long p = 0; p < n; p++)
            {
                v.Add((long.Parse(input[p]), p));
            }

            v.Sort((a, b) => a.value.CompareTo(b.value));

            long cnt = 0;
            for (long p = 1; p < n; p++)
            {
                if (v[(int)p].index < v[(int)(p - 1)].index)
                    cnt++;
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
        StyleHelper.Title("Split Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
