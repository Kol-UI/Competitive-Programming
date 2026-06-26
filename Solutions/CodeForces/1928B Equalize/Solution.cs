// Equalize
namespace CompetitiveProgramming.CodeForces.Equalize;
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
            
            List<long> v = new List<long>();
            HashSet<long> s = new HashSet<long>();
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (s.Contains(x)) continue;
                v.Add(x);
                s.Add(x);
            }
            
            v.Sort();
            
            long idx = 0;
            long ans = 0;
            
            for (long p = 0; p < v.Count; p++)
            {
                while (idx + 1 < v.Count && v[(int)(idx + 1)] < v[(int)p] + n)
                {
                    idx++;
                }
                long len = idx - p + 1;
                if (len > ans) ans = len;
                if (idx + 1 == v.Count) break;
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Equalize");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}