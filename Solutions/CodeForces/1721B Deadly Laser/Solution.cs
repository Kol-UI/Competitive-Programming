// Deadly Laser
namespace CompetitiveProgramming.CodeForces.DeadlyLaser;
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
            long m = input[1];
            long sx = input[2];
            long sy = input[3];
            long d = input[4];
            
            long leftDistance = sx - 1;
            long rightDistance = m - sy;
            long min1 = Math.Min(leftDistance, rightDistance);
            
            long bottomDistance = n - sx;
            long topDistance = sy - 1;
            long min2 = Math.Min(bottomDistance, topDistance);
            
            bool canReach = min1 > d || min2 > d;
            long result = canReach ? n + m - 2 : -1;
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
        StyleHelper.Title("Deadly Laser");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}