// Calculate Function


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.CalculateFunction;

class Program
{
    //static void Main()
    static void Solution()
    {
        long n = long.Parse(Console.ReadLine()!);

        long result = (n % 2 == 0) ? n / 2 : -(n + 1) / 2;

        Console.WriteLine(result);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Calculate Function");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}