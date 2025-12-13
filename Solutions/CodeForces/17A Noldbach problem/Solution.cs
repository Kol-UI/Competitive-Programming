// Noldbach problem
namespace CompetitiveProgramming.CodeForces.Noldbachproblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int limit = int.Parse(input[0]);
        int target = int.Parse(input[1]);
        
        bool[] sieve = new bool[limit + 1];
        for (int i = 2; i <= limit; i++) sieve[i] = true;
        
        for (int i = 2; i * i <= limit; i++)
        {
            if (!sieve[i]) continue;
            for (int j = i * i; j <= limit; j += i) sieve[j] = false;
        }
        
        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (sieve[i]) primes.Add(i);
        }
        
        int count = 0;
        for (int i = 2; i < primes.Count; i++)
        {
            for (int j = 0; j < i - 1; j++)
            {
                if (primes[j] + primes[j + 1] + 1 == primes[i])
                {
                    count++;
                    break;
                }
            }
        }
        
        Console.WriteLine(count >= target ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Noldbach problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}