// Letter Home
namespace CompetitiveProgramming.CodeForces.LetterHome;
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
            long s = input[1];
            
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long leftDistance = 0;
            long rightDistance = 0;
            
            foreach (long number in numbers)
            {
                if (number < s)
                {
                    long distance = s - number;
                    leftDistance = Math.Max(leftDistance, distance);
                }
                else
                {
                    long distance = number - s;
                    rightDistance = Math.Max(rightDistance, distance);
                }
            }
            
            long total = leftDistance + rightDistance + Math.Min(leftDistance, rightDistance);
            Console.WriteLine(total);
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
        StyleHelper.Title("Letter Home");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}