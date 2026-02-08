// Kill the Monster
namespace CompetitiveProgramming.CodeForces.KilltheMonster;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var stats = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long hc = stats[0];
            long dc = stats[1];
            
            stats = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long hm = stats[0];
            long dm = stats[1];
            
            stats = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long k = stats[0];
            long w = stats[1];
            long a = stats[2];
            
            bool win = false;
            for(long p = 0; p <= k; p++)
            {
                long dct = dc + p * w;
                long hct = hc + (k - p) * a;
                long fa = (hm + dct - 1) / dct;
                long fb = (hct + dm - 1) / dm;
                if(fa <= fb)
                {
                    win = true;
                    break;
                }
            }
            
            Console.WriteLine(win ? "YES" : "NO");
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
        StyleHelper.Title("Kill the Monster");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}