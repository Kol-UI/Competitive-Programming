// Replace with Occurrences
namespace CompetitiveProgramming.CodeForces.ReplacewithOccurrences;
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
            
            Dictionary<long, List<long>> m = new Dictionary<long, List<long>>();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (!m.ContainsKey(x))
                    m[x] = new List<long>();
                m[x].Add(p);
            }
            
            bool possible = true;
            foreach (var kvp in m)
            {
                long key = kvp.Key;
                long len = kvp.Value.Count;
                if (len % key != 0)
                {
                    possible = false;
                    break;
                }
            }
            
            if (!possible)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            long num = 0;
            long[] v = new long[n];
            foreach (var kvp in m)
            {
                long key = kvp.Key;
                List<long> w = kvp.Value;
                for (long p = 0; p < w.Count; p++)
                {
                    if (p % key == 0) num++;
                    v[w[(int)p]] = num;
                }
            }
            
            for (long p = 0; p < v.Length; p++)
            {
                Console.Write($"{v[p]} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("Replace with Occurrences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}