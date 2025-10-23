// Hungry Student Problem
namespace CompetitiveProgramming.CodeForces.HungryStudentProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        const int N = 107;
        const int A = 3;
        const int B = 7;
        
        bool[] dp = new bool[N];
        for (int p = 0; p < N; p++)
        {
            dp[p] = (p % A == 0) || (p % B == 0) || 
                   (p >= A && dp[p - A]) || 
                   (p >= B && dp[p - B]);
        }
        
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(dp[x] ? "YES" : "NO");
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
        StyleHelper.Title("Hungry Student Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}