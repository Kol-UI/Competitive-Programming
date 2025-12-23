// Contest for Robots
namespace CompetitiveProgramming.CodeForces.ContestforRobots;
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
        int n = int.Parse(Console.ReadLine());
        long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        long first = 0;
        long second = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (a[i] == b[i]) continue;
            else if (a[i] == 1) first++;
            else if (b[i] == 1) second++;
        }
        
        long result = first > 0 ? 1 + second / first : -1;
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Contest for Robots");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}