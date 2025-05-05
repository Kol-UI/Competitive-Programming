// Almost Prime
namespace CompetitiveProgramming.CodeForces.AlmostPrime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    static List<int> v = new List<int>();

    static void Solve(int n)
    {
        int[] prime = new int[n + 1];
        for (int i = 2; i * i <= n; i++)
        {
            if (prime[i] == 0)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    prime[j] = 1;
                }
            }
        }
        for (int i = 2; i <= 3000; i++)
        {
            if (prime[i] == 0)
                v.Add(i);
        }
    }

    static int PrimeFact(int n)
    {
        int cnt = 0;
        foreach (int p in v)
        {
            if (n % p == 0)
                cnt++;
            if (cnt > 2)
                break;
            if (p > (n / 2) + 1)
                break;
        }
        return cnt == 2 ? 1 : 0;
    }

    //static void Main()
    public static void MainSolution()
    {
        Solve(3000);
        int n = int.Parse(Console.ReadLine()!);
        int cnt = 0;
        for (int i = 6; i <= n; i++)
        {
            if (PrimeFact(i) == 1)
                cnt++;
        }
        Console.WriteLine(cnt);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Almost Prime");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}