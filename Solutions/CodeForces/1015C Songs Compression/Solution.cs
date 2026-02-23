// Songs Compression
namespace CompetitiveProgramming.CodeForces.SongsCompression;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long n = input[0];
        long m = input[1];
        
        long sumA = 0;
        long totalDiff = 0;
        List<long> diffs = new List<long>();
        
        for(long p = 0; p < n; p++)
        {
            var values = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = values[0];
            long b = values[1];
            sumA += a;
            long diff = a - b;
            totalDiff += diff;
            diffs.Add(diff);
        }
        
        if(sumA <= m)
        {
            Console.WriteLine("0");
            return;
        }
        else if(m < sumA - totalDiff)
        {
            Console.WriteLine("-1");
            return;
        }
        else
        {
            diffs.Sort((x, y) => y.CompareTo(x));
            long cnt = 0;
            for(long p = 0; p < n; p++)
            {
                sumA -= diffs[(int)p];
                if(sumA <= m)
                {
                    cnt = p + 1;
                    break;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Songs Compression");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}