// Sort Zero
namespace CompetitiveProgramming.CodeForces.SortZero;
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
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            HashSet<long> s = new HashSet<long>();
            long cur = a[n - 1];
            
            for(int p = n - 2; p >= 0; p--)
            {
                if(a[p] > cur)
                {
                    s.Add(a[p]);
                }
                else
                {
                    cur = a[p];
                }
            }
            
            bool flag = false;
            for(int p = n - 1; p >= 0; p--)
            {
                if(flag)
                {
                    s.Add(a[p]);
                }
                else if(s.Contains(a[p]))
                {
                    flag = true;
                }
            }
            
            Console.WriteLine(s.Count);
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
        StyleHelper.Title("Sort Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}