// Tab Closing
namespace CompetitiveProgramming.CodeForces.TabClosing;
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
        
        for (int test = 0; test < testCases; test++)
        {
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = numbers[0];
            long b = numbers[1];
            long n = numbers[2];
            
            int result = (a >= n * b || a == b) ? 1 : 2;
            Console.WriteLine(result);
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
        StyleHelper.Title("Tab Closing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}