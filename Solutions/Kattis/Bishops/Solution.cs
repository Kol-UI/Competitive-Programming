// Bishops
namespace CompetitiveProgramming.Kattis.Bishops;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            Console.WriteLine(Math.Max(1, 2 * n - 2));
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bishops");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}