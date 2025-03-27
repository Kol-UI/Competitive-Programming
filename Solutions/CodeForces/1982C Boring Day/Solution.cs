// Boring Day
namespace CompetitiveProgramming.CodeForces.BoringDay;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            long n = long.Parse(input[0]);
            long l = long.Parse(input[1]);
            long r = long.Parse(input[2]);
            
            long[] v = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            
            long s = 0, ans = 0;
            long sum = 0;
            for (int e = 0; e < n; e++)
            {
                sum += v[e];
                while (sum > r && s <= e)
                {
                    sum -= v[s];
                    s++;
                }
                if (sum >= l && sum <= r)
                {
                    ans++;
                    sum = 0;
                    s = e + 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Boring Day");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}