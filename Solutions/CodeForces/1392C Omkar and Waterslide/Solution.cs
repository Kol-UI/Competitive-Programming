// Omkar and Waterslide
namespace CompetitiveProgramming.CodeForces.OmkarandWaterslide;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            long ans = 0;
            for (int i = n - 1; i > 0; i--)
            {
                ans += Math.Max(0, v[i - 1] - v[i]);
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
        StyleHelper.Title("Omkar and Waterslide");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}