// Test of Love
namespace CompetitiveProgramming.CodeForces.TestofLove;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);
            long k = long.Parse(firstLine[2]);
            
            string s = Console.ReadLine();
            s = "L" + s + "L";
            
            List<long> v = new List<long>();
            for (long p = 0; p < s.Length; p++)
            {
                if (s[(int)p] == 'L') v.Add(p);
            }
            
            bool possible = true;
            for (long p = 0; possible && p + 1 < v.Count; p++)
            {
                if (v[(int)p] + m >= v[(int)(p + 1)])
                {
                    continue;
                }
                
                long cur = v[(int)p] + m;
                long nxt = v[(int)(p + 1)];
                long dist = nxt - cur;
                
                if (dist <= k)
                {
                    k -= dist;
                }
                else
                {
                    possible = false;
                    break;
                }
                
                for (long u = cur; u < nxt; u++)
                {
                    if (s[(int)u] == 'C')
                    {
                        possible = false;
                        break;
                    }
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Test of Love");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}