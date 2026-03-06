// Quests
namespace CompetitiveProgramming.CodeForces.Quests;
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
            
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int sumA = 0;
            int maxB = 0;
            int result = 0;
            
            for(int p = 0; p < n && p < k; p++)
            {
                sumA += a[p];
                if(b[p] > maxB) maxB = b[p];
                
                int current = sumA + (k - p - 1) * maxB;
                if(current > result) result = current;
            }
            
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
        StyleHelper.Title("Quests");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}