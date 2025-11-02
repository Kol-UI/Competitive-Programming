// Draw a Square
namespace CompetitiveProgramming.CodeForces.DrawaSquare;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long l = numbers[0];
            long r = numbers[1];
            long d = numbers[2];
            long u = numbers[3];
            
            bool allEqual = l == r && r == d && d == u;
            Console.WriteLine(allEqual ? "Yes" : "No");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Draw a Square");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}