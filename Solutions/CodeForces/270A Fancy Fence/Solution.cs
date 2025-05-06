// Fancy Fence
namespace CompetitiveProgramming.CodeForces.FancyFence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int a = int.Parse(Console.ReadLine()!);
            double n = 360.0 / (180 - a);
            Console.WriteLine(n == (int)n ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fancy Fence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}