// Conveyor Belts
namespace CompetitiveProgramming.CodeForces.ConveyorBelts;
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
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0];
            long x1 = input[1];
            long y1 = input[2];
            long x2 = input[3];
            long y2 = input[4];
            
            long start = Math.Min(Math.Min(x1, n + 1 - x1), Math.Min(y1, n + 1 - y1));
            long finish = Math.Min(Math.Min(x2, n + 1 - x2), Math.Min(y2, n + 1 - y2));
            
            long distance = Math.Abs(start - finish);
            Console.WriteLine(distance);
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
        StyleHelper.Title("Conveyor Belts");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}