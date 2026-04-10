// Two Out of Three
namespace CompetitiveProgramming.CodeForces.TwoOutofThree;
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
        const int B = 107;
        long t = long.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            List<int>[] m = new List<int>[B];
            for (int i = 0; i < B; i++) m[i] = new List<int>();
            
            long[] a = new long[n];
            long[] b = new long[n];
            for (long i = 0; i < n; i++) b[i] = 1;
            
            long dupes = 0;
            string[] input = Console.ReadLine().Split();
            
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(input[p]);
                m[a[p]].Add((int)p);
                if (m[a[p]].Count == 2) dupes++;
            }
            
            if (dupes < 2)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            int cur = 0;
            for (int p = 0; p < B; p++)
            {
                if (m[p].Count < 2) continue;
                b[m[p][0]] = 2 + cur;
                cur = 1 - cur;
            }
            
            for (long p = 0; p < n; p++)
            {
                Console.Write($"{b[p]} ");
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
        StyleHelper.Title("Two Out of Three");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}