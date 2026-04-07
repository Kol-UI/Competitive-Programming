// 2048 Game
namespace CompetitiveProgramming.CodeForces.TwothousandandfortyeightGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        const long D = 12;
        long q = long.Parse(Console.ReadLine());
        
        while (q-- > 0)
        {
            List<long> a = new List<long>();
            for (long i = 0; i < D; i++) a.Add(0);
            
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            
            for (long i = 0; i < n; i++)
            {
                long x = long.Parse(input[i]);
                for (long p = 0; x != 0 && p < D; x /= 2, p++)
                {
                    if (x == 1) a[(int)p]++;
                }
            }
            
            for (long p = 1; p < D; p++)
            {
                a[(int)p] += a[(int)(p - 1)] / 2;
            }
            
            Console.WriteLine(a[(int)(D - 1)] != 0 ? "YES" : "NO");
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
        StyleHelper.Title("2048 Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}