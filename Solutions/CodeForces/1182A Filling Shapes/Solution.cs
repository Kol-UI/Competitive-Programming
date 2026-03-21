// Filling Shapes
namespace CompetitiveProgramming.CodeForces.Shapes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        long result = n % 2 == 1 ? 0 : 1L << (n / 2);
        
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Filling Shapes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}