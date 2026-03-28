// Permutations & Primes
namespace CompetitiveProgramming.CodeForces.PermutationsAndPrimes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
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
            
            if(n == 1)
            {
                Console.WriteLine("1");
                continue;
            }
            else if(n == 2)
            {
                Console.WriteLine("2 1");
                continue;
            }
            
            int[] a = new int[n];
            a[0] = 2;
            a[n / 2] = 1;
            a[n - 1] = 3;
            int current = 4;
            
            for(int p = 1; p + 1 < n; p++)
            {
                if(a[p] != 0) continue;
                a[p] = current;
                current++;
            }
            
            Console.WriteLine(string.Join(" ", a.Select(x => x.ToString()).ToArray()));
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Permutations & Primes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}