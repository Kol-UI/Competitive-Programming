// Water Lily
namespace CompetitiveProgramming.CodeForces.WaterLily;
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
        string[] input = Console.ReadLine().Split();
        double h = double.Parse(input[0]);
        double l = double.Parse(input[1]);
        
        double result = (l * l - h * h) / (2.0 * h);
        Console.WriteLine(result.ToString("F8"));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Water Lily");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}