// Kyoya and Photobooks
namespace CompetitiveProgramming.CodeForces.KyoyaandPhotobooks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        long n = s.Length;
        long result = 26 + (25 * n);
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kyoya and Photobooks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}