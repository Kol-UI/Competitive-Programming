// Long Jumps
namespace CompetitiveProgramming.CodeForces.LongJumps;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            long[] v = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long ans = -1;
            
            for (int i = n - 1; i >= 0; i--)
            {
                if (i + v[i] < n)
                    v[i] += v[i + (int)v[i]];
                ans = Math.Max(ans, v[i]);
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
        StyleHelper.Title("Long Jumps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}