// Unit Array
namespace CompetitiveProgramming.CodeForces.UnitArray;
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
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            long positiveCount = 0;
            long negativeCount = 0;
            
            foreach (int number in numbers)
            {
                if (number > 0) positiveCount++;
                if (number < 0) negativeCount++;
            }
            
            long moves = 0;
            if (positiveCount < negativeCount)
            {
                moves = (negativeCount - positiveCount + 1) / 2;
                positiveCount += moves;
                negativeCount -= moves;
            }
            
            if (negativeCount % 2 == 1) moves++;
            
            Console.WriteLine(moves);
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
        StyleHelper.Title("Unit Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}