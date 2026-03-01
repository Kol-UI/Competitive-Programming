// New Colony
namespace CompetitiveProgramming.CodeForces.NewColony;
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
            
            int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            if(k > 100 * n)
            {
                Console.WriteLine("-1");
                continue;
            }
            
            int result = -1;
            
            for(int step = 0; step < k; step++)
            {
                int idx = 0;
                while(idx < n - 1 && h[idx] >= h[idx + 1])
                {
                    idx++;
                }
                
                if(idx >= n - 1)
                {
                    result = -1;
                    break;
                }
                
                h[idx]++;
                result = idx + 1;
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
        StyleHelper.Title("New Colony");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}