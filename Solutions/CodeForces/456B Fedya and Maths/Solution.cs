// Fedya and Maths
namespace CompetitiveProgramming.CodeForces.FedyaandMaths;
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
        string input = Console.ReadLine();
        int N = input.Length;

        int n = 0;
        if (N >= 2)
            n = 10 * (input[N - 2] - '0');
        n += input[N - 1] - '0';

        int result = 0;

        if (n % 4 == 0)
            result = (1 + 1 + 1 + 1) % 5;
        else if (n % 4 == 1)
            result = (1 + 2 + 3 + 4) % 5;
        else if (n % 4 == 2)
            result = (1 + 4 + 4 + 1) % 5;
        else if (n % 4 == 3)
            result = (1 + 3 + 2 + 4) % 5;

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
        StyleHelper.Title("Fedya and Maths");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}