// Different Divisors
namespace CompetitiveProgramming.CodeForces.DifferentDivisors;
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
    static List<int> prime = new List<int>();

    static void Solve()
    {
        bool[] temp = new bool[N + 10];
        Array.Fill(temp, true);
        
        for (int i = 4; i <= N; i += 2)
            temp[i] = false;
        
        for (int i = 3; i * i <= N; i += 2)
        {
            if (temp[i])
            {
                for (int j = i * i; j <= N; j += i)
                    temp[j] = false;
            }
        }
        
        for (int i = 2; i <= N; i++)
            if (temp[i])
                prime.Add(i);
    }

    const int N = 1000000;

    //static void Main()
    public static void MainSolution()
    {
        Solve();
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int d = int.Parse(Console.ReadLine());
            int x = d + 1;
            int f1 = prime.BinarySearch(x);
            if (f1 < 0) f1 = ~f1;
            
            int target = prime[f1] + d;
            int f2 = prime.BinarySearch(target);
            if (f2 < 0) f2 = ~f2;
            
            Console.WriteLine(prime[f1] * prime[f2]);
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
        StyleHelper.Title("Different Divisors");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}