// Emordnilap
namespace CompetitiveProgramming.CodeForces.Emordnilap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Program
{
    private const int Mod = 1000000007;
    private const int N = 100000 + 10;
    private static List<long> fact = new List<long>(new long[N]);

    private static void Pre()
    {
        fact[0] = 1;
        for (int i = 1; i < N; i++)
        {
            fact[i] = (fact[i - 1] * i) % Mod;
        }
    }

    //public static void Main(string[] args)
    public static void MainSolution()
    {
        Pre();
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            long ans = (n * (long)(n - 1)) % Mod;
            ans = (ans * fact[n]) % Mod;
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Emordnilap");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}