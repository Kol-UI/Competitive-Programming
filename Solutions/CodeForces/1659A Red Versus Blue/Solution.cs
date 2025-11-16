// Red Versus Blue
namespace CompetitiveProgramming.CodeForces.RedVersusBlue;
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
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int b = int.Parse(input[2]);
            
            int segmentSize = r / (b + 1);
            int remainder = r % (b + 1);
            
            for (int segment = 0; segment <= b; segment++)
            {
                int redCount = segmentSize + (segment < remainder ? 1 : 0);
                Console.Write(new string('R', redCount));
                if (segment < b) Console.Write('B');
            }
            
            Console.WriteLine();
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
        StyleHelper.Title("Red Versus Blue");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}