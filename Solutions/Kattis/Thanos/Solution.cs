// Thanos
namespace CompetitiveProgramming.Kattis.Thanos;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Solve()
    {
        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);
        long c = long.Parse(input[2]);
        
        long ct = 0;
        while (a <= c)
        {
            a *= b;
            ct++;
        }
        
        Console.WriteLine(ct);
    }
    
    static void Main()
    {
        long cases = long.Parse(Console.ReadLine());
        while (cases-- > 0)
        {
            Solve();
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
        StyleHelper.Title("Thanos");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}