// Kill Demodogs
namespace CompetitiveProgramming.CodeForces.KillDemodogs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.IO;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        const long MOD = 1000000007L;
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            long res = 337L;
            res = (res * n) % MOD;
            res = (res * (n + 1)) % MOD;
            res = (res * ((4L * n - 1) % MOD)) % MOD;
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kill Demodogs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}