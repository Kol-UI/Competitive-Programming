// Discounts
namespace CompetitiveProgramming.CodeForces.BDiscounts;
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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            Array.Sort(a);
            Array.Reverse(a);
            Array.Sort(b);
            
            long idx = -1;
            for(int p = 0; p < k; p++)
            {
                if(idx + b[p] >= n) break;
                idx += b[p];
                a[idx] = 0;
            }
            
            long cost = 0;
            foreach(long x in a) cost += x;
            Console.WriteLine(cost);
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
        StyleHelper.Title("Discounts");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}