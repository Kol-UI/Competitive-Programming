// Closest Point
namespace CompetitiveProgramming.CodeForces.ClosestPoint;
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
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long last = numbers[n - 1];
            long secondLast = numbers[n - 2];
            
            bool condition = n == 2 && Math.Abs(secondLast - last) > 1;
            Console.WriteLine(condition ? "YES" : "NO");
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
        StyleHelper.Title("Closest Point");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}