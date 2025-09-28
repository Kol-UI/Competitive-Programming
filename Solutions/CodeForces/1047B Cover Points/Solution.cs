// Cover Points
namespace CompetitiveProgramming.CodeForces.CoverPoints;
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
        int numberOfPairs = int.Parse(Console.ReadLine());
        int maximumSum = 0;
        
        for (int i = 0; i < numberOfPairs; i++)
        {
            string[] pair = Console.ReadLine().Split();
            int firstNumber = int.Parse(pair[0]);
            int secondNumber = int.Parse(pair[1]);
            
            int currentSum = firstNumber + secondNumber;
            maximumSum = Math.Max(maximumSum, currentSum);
        }
        
        Console.WriteLine(maximumSum);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cover Points");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}