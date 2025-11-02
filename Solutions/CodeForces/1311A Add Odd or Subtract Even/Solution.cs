// Add Odd or Subtract Even
namespace CompetitiveProgramming.CodeForces.AddOddorSubtractEven;
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
            long a = numbers[0];
            long b = numbers[1];
            
            if (a == b)
            {
                Console.WriteLine("0");
            }
            else if (b > a && (b - a) % 2 == 1)
            {
                Console.WriteLine("1");
            }
            else if (b > a && (b - a) % 2 == 0)
            {
                Console.WriteLine("2");
            }
            else if (a > b && (a - b) % 2 == 0)
            {
                Console.WriteLine("1");
            }
            else if (a > b && (a - b) % 2 == 1)
            {
                Console.WriteLine("2");
            }
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
        StyleHelper.Title("Add Odd or Subtract Even");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}