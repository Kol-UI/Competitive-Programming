// Chocolates
namespace CompetitiveProgramming.CodeForces.Chocolates;
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
        int n = int.Parse(Console.ReadLine());
        long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        long maxAllowed = 1000000011;
        long total = 0;
        
        for(int p = n - 1; p >= 0; p--)
        {
            if(maxAllowed <= 1) break;
            
            if(a[p] >= maxAllowed)
            {
                a[p] = maxAllowed - 1;
            }
            
            total += a[p];
            maxAllowed = a[p];
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Chocolates");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}