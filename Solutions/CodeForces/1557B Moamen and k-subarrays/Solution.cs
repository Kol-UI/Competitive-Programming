// Moamen and k-subarrays
namespace CompetitiveProgramming.CodeForces.Moamenandksubarrays;
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
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = firstLine[0];
            int k = firstLine[1];
            
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            List<(int value, int index)> v = new List<(int, int)>();
            for(int p = 0; p < n; p++)
            {
                v.Add((a[p], p));
            }
            
            v = v.OrderBy(x => x.value).ToList();
            
            int cnt = 1;
            for(int p = 1; p < n; p++)
            {
                if(v[p].index != v[p - 1].index + 1)
                {
                    cnt++;
                }
            }
            
            Console.WriteLine(cnt <= k ? "YES" : "NO");
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
        StyleHelper.Title("Moamen and k-subarrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}