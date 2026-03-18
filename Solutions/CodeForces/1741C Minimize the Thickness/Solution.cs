// Minimize the Thickness
namespace CompetitiveProgramming.CodeForces.MinimizetheThickness;
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
            
            long[] prefixSum = new long[n];
            prefixSum[0] = a[0];
            for(int p = 1; p < n; p++)
            {
                prefixSum[p] = prefixSum[p - 1] + a[p];
            }
            
            long result = n;
            
            for(int k = 0; k < n; k++)
            {
                long target = prefixSum[k];
                
                if(prefixSum[n - 1] % target != 0) continue;
                
                long currentSum = 0;
                int maxLength = 0;
                int currentLength = 0;
                bool possible = true;
                
                for(int p = 0; p < n; p++)
                {
                    currentSum += a[p];
                    currentLength++;
                    
                    if(currentSum == target)
                    {
                        if(currentLength > maxLength) maxLength = currentLength;
                        currentSum = 0;
                        currentLength = 0;
                    }
                    else if(currentSum > target)
                    {
                        possible = false;
                        break;
                    }
                }
                
                if(possible && maxLength < result)
                {
                    result = maxLength;
                }
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
        StyleHelper.Title("Minimize the Thickness");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}