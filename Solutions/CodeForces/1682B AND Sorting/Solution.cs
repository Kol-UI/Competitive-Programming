// AND Sorting
namespace CompetitiveProgramming.CodeForces.ANDSorting;
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
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int x = 0;
            bool start = false;
            
            for(int p = 0; p < n; p++)
            {
                if(a[p] == p) continue;
                
                if(!start)
                {
                    start = true;
                    x = a[p];
                }
                else
                {
                    x &= a[p];
                }
            }
            
            Console.WriteLine(x);
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
        StyleHelper.Title("AND Sorting");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}