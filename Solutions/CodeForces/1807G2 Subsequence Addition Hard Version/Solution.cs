// Subsequence Addition (Hard Version)
namespace CompetitiveProgramming.CodeForces.SubsequenceAdditionHardVersion;
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
            
            Array.Sort(a);
            
            bool possible = a[0] == 1;
            long sum = 1;
            
            for(int p = 1; possible && p < n; p++)
            {
                if(sum < a[p])
                {
                    possible = false;
                }
                else
                {
                    sum += a[p];
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Subsequence Addition (Hard Version)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}