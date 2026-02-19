// Medians
namespace CompetitiveProgramming.CodeForces.Medians;
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
            
            if(n == 1 && k == 1)
            {
                Console.WriteLine("1 1");
            }
            else if(k == 1 || k == n)
            {
                Console.WriteLine("-1");
            }
            else if(k % 2 == 1)
            {
                Console.WriteLine($"3\n1 {k - 1} {k + 2}");
            }
            else
            {
                Console.WriteLine($"3\n1 {k} {k + 1}");
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
        StyleHelper.Title("Medians");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}