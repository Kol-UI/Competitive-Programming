// Subsequence Update
namespace CompetitiveProgramming.CodeForces.SubsequenceUpdate;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var firstLine = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = firstLine[0];
            long l = firstLine[1];
            long r = firstLine[2];
            
            long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            List<long> vl = new List<long>();
            List<long> vs = new List<long>();
            List<long> vr = new List<long>();
            long sum = 0;
            
            for(int p = 0; p < n; p++)
            {
                if(p < l - 1)
                {
                    vl.Add(x[p]);
                }
                else if(p < r)
                {
                    vs.Add(x[p]);
                    sum += x[p];
                }
                else
                {
                    vr.Add(x[p]);
                }
            }
            
            vl.Sort();
            vr.Sort();
            vs.Sort((a, b) => b.CompareTo(a));
            
            long diffA = 0;
            for(int p = 0; p < Math.Min(vl.Count, vs.Count); p++)
            {
                if(vl[p] < vs[p])
                {
                    diffA += vl[p] - vs[p];
                }
                else
                {
                    break;
                }
            }
            
            long diffB = 0;
            for(int p = 0; p < Math.Min(vr.Count, vs.Count); p++)
            {
                if(vr[p] < vs[p])
                {
                    diffB += vr[p] - vs[p];
                }
                else
                {
                    break;
                }
            }
            
            long result = sum + Math.Min(diffA, diffB);
            Console.WriteLine(result);
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
        StyleHelper.Title("Subsequence Update");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}