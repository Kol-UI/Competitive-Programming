// Sort with Step
namespace CompetitiveProgramming.CodeForces.SortwithStep;
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
            long k = input[1];
            
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long badPositions = 0;
            
            for (int position = 0; position < n; position++)
            {
                long value = numbers[position] - 1;
                if (value % k != position % k)
                {
                    badPositions++;
                }
            }
            
            if (badPositions == 0) Console.WriteLine("0");
            else if (badPositions == 2) Console.WriteLine("1");
            else Console.WriteLine("-1");
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
        StyleHelper.Title("Sort with Step");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}