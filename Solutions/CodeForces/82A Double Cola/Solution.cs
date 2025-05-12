// Double Cola
namespace CompetitiveProgramming.CodeForces.DoubleCola;
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
        int n = int.Parse(Console.ReadLine()!);
        List<string> v = new List<string> { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
        int x = 1;
        
        while (x * 5 < n)
        {
            n -= x * 5;
            x *= 2;
        }
        
        Console.WriteLine(v[(n - 1) / x]);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Double Cola");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}