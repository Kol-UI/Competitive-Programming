// Beautiful XOR
namespace CompetitiveProgramming.CodeForces.BeautifulXOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0];
            long b = input[1];
            
            long x = a ^ b;
            List<long> v = new List<long>();
            
            for(int p = 0; x != 0 && p < 100; p++, x /= 2)
            {
                if(x % 2 == 0) continue;
                if((1L << p) > a) break;
                v.Add(1L << p);
            }
            
            if(x != 0)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            Console.WriteLine(v.Count);
            if(v.Count > 0)
            {
                Console.WriteLine(string.Join(" ", v.Select(x => x.ToString()).ToArray()));
            }
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
        StyleHelper.Title("Beautiful XOR");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}