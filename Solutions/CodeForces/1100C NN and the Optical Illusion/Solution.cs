// NN and the Optical Illusion
namespace CompetitiveProgramming.CodeForces.NNandtheOpticalIllusion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        const double PI = 3.14159265;

        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        double r = double.Parse(input[1], System.Globalization.CultureInfo.InvariantCulture);

        Console.WriteLine((r * Math.Sin(PI / n) / (1 - Math.Sin(PI / n))).ToString("F8", System.Globalization.CultureInfo.InvariantCulture));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("NN and the Optical Illusion");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}