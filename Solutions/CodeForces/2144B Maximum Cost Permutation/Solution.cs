// Maximum Cost Permutation
namespace CompetitiveProgramming.CodeForces.MaximumCostPermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] v = new long[n];
            SortedSet<long> s = new SortedSet<long>();
            string[] input = Console.ReadLine().Split();
            
            for (long p = 0; p < n; p++)
            {
                v[p] = long.Parse(input[p]);
                s.Add(p + 1);
            }
            
            for (long p = 0; p < n; p++)
            {
                if (v[p] != 0) s.Remove(v[p]);
            }
            
            for (long p = n - 1; p >= 0; p--)
            {
                if (v[p] == 0)
                {
                    v[p] = s.Min;
                    s.Remove(s.Min);
                }
            }
            
            long left = n, right = -1;
            for (long p = 0; p < n; p++)
            {
                if (v[p] != p + 1)
                {
                    left = p;
                    break;
                }
            }
            for (long p = n - 1; p >= 0; p--)
            {
                if (v[p] != p + 1)
                {
                    right = p;
                    break;
                }
            }
            
            Console.WriteLine((left < right) ? (right - left + 1) : 0);
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
        StyleHelper.Title("Maximum Cost Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}