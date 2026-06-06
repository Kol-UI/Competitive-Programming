// Yet Another Coin Problem
namespace CompetitiveProgramming.CodeForces.YetAnotherCoinProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static long F(long n)
    {
        if (n < 0) return 1000000000;
        
        long cnt = 0;
        cnt += (n / 15); n %= 15;
        cnt += (n / 6);  n %= 6;
        cnt += (n / 3);  n %= 3;
        cnt += n;
        return cnt;
    }
    
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long zeroTens = F(n);
            long oneTens  = 1 + F(n - 10);
            long twoTens  = 2 + F(n - 20);
            long ans = (zeroTens < oneTens) ? zeroTens : oneTens;
            ans = (ans < twoTens) ? ans : twoTens;
            Console.WriteLine(ans);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Yet Another Coin Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}