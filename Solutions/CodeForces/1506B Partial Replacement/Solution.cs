// Partial Replacement
namespace CompetitiveProgramming.CodeForces.PartialReplacement;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0];
            long k = input[1];
            
            string s = Console.ReadLine();
            
            long cnt = 0, prev = -1, last = -1;
            for(int p = 0; p < s.Length; p++)
            {
                if(s[p] == '.') continue;
                if(prev < 0)
                {
                    cnt++;
                    prev = p;
                    continue;
                }
                if(p > prev + k)
                {
                    cnt++;
                    prev = last;
                }
                last = p;
            }
            
            long result = cnt + (prev < last ? 1 : 0);
            Console.WriteLine(result);
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
        StyleHelper.Title("Partial Replacement");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}