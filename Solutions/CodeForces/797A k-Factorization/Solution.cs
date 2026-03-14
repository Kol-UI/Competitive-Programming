// k-Factorization
namespace CompetitiveProgramming.CodeForces.kFactorization;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        long n = input[0];
        int k = input[1];
        
        List<long> factors = new List<long>();
        long divisor = 2;
        long remaining = n;
        
        while(remaining > 1)
        {
            if(remaining % divisor == 0)
            {
                factors.Add(divisor);
                remaining /= divisor;
            }
            else
            {
                divisor++;
            }
        }
        
        if(factors.Count < k)
        {
            Console.WriteLine("-1");
        }
        else
        {
            for(int p = 0; p < k - 1; p++)
            {
                Console.Write($"{factors[p]} ");
            }
            
            long lastFactor = 1;
            for(int p = k - 1; p < factors.Count; p++)
            {
                lastFactor *= factors[p];
            }
            Console.WriteLine(lastFactor);
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
        StyleHelper.Title("k-Factorization");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}