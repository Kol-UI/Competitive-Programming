// T-primes
namespace CompetitiveProgramming.CodeForces.Tprimes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    const int MAX = 1000000;
    static bool[] isPrime = new bool[MAX + 1];
    static HashSet<long> tPrimes = new HashSet<long>();

    static void Solve()
    {
        for (int i = 2; i <= MAX; i++)
            isPrime[i] = true;

        for (int i = 2; i * i <= MAX; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= MAX; j += i)
                    isPrime[j] = false;
            }
        }

        tPrimes.Add(4);
        for (int i = 3; i <= MAX; i += 2)
        {
            if (isPrime[i])
                tPrimes.Add((long)i * i);
        }
    }

    //static void Main()
    public static void MainSolution()
    {
        Solve();
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split();
        
        for (int i = 0; i < n; i++)
        {
            long x = long.Parse(numbers[i]);
            Console.WriteLine(tPrimes.Contains(x) ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("T-primes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}