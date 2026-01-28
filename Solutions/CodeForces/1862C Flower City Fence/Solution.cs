// Flower City Fence
namespace CompetitiveProgramming.CodeForces.FlowerCityFence;
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
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long[] w = new long[n + 1];
            bool res = true;
            
            for(int p = 0; p < n && res; p++)
            {
                w[0]++;
                if(v[p] > n)
                {
                    res = false;
                }
                else
                {
                    w[v[p]]--;
                }
            }
            
            long cs = 0;
            for(int p = 0; p < n && res; p++)
            {
                cs += w[p];
                if(cs != v[p])
                {
                    res = false;
                }
            }
            
            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Flower City Fence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}