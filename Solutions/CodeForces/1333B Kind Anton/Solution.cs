// Kind Anton
namespace CompetitiveProgramming.CodeForces.KindAnton;
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
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long minus = n + 1, plus = n + 1;
            for(int p = 0; p < n; p++)
            {
                if(minus > n && a[p] < 0) minus = p;
                if(plus > n && a[p] > 0) plus = p;
            }
            
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            bool res = true;
            
            for(int p = 0; p < n; p++)
            {
                if(b[p] < a[p] && minus >= p) res = false;
                if(b[p] > a[p] && plus >= p) res = false;
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
        StyleHelper.Title("Kind Anton");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}