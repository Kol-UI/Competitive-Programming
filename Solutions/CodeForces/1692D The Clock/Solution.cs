// The Clock
namespace CompetitiveProgramming.CodeForces.TheClock;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

public class Solution
{
    const int B = 24 * 60;
    
    static bool IsPalin(long x)
    {
        long h = x / 60;
        long m = x % 60;
        return (h / 10 == m % 10) && (h % 10 == m / 10);
    }
    
    static long Convert(string x)
    {
        return 10 * 60 * (x[0] - '0') + 60 * (x[1] - '0') + 10 * (x[3] - '0') + (x[4] - '0');
    }
    
    static public void Main()
    {
        HashSet<long> palins = new HashSet<long>();
        for(long min = 0; min < B; min++)
        {
            if(IsPalin(min)) palins.Add(min);
        }
        
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var parts = Console.ReadLine().Split();
            string s = parts[0];
            long interval = long.Parse(parts[1]);
            
            long start = Convert(s);
            long cur = start;
            long cnt = palins.Contains(start) ? 1 : 0;
            
            for(long p = 1; p < B; p++)
            {
                cur = (cur + interval) % B;
                if(cur == start) break;
                if(palins.Contains(cur)) cnt++;
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
        StyleHelper.Title("The Clock");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}