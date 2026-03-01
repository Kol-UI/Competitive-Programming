// Variety is Discouraged
namespace CompetitiveProgramming.CodeForces.VarietyisDiscouraged;
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
            int n = int.Parse(Console.ReadLine());
            long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            HashSet<long> singles = new HashSet<long>();
            HashSet<long> dupes = new HashSet<long>();
            
            foreach(long num in v)
            {
                if(dupes.Contains(num)) continue;
                else if(singles.Contains(num))
                {
                    dupes.Add(num);
                    singles.Remove(num);
                }
                else
                {
                    singles.Add(num);
                }
            }
            
            long currentLeft = -1;
            long maxLength = -1;
            long leftResult = -1;
            long rightResult = -1;
            
            for(int p = 0; p < n; p++)
            {
                if(singles.Contains(v[p]))
                {
                    if(currentLeft < 0) currentLeft = p;
                    if(p - currentLeft + 1 > maxLength)
                    {
                        maxLength = p - currentLeft + 1;
                        leftResult = currentLeft + 1;
                        rightResult = p + 1;
                    }
                }
                else
                {
                    currentLeft = -1;
                }
            }
            
            if(leftResult < 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{leftResult} {rightResult}");
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
        StyleHelper.Title("Variety is Discouraged");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}