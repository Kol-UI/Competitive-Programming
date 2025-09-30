// Parity Alternated Deletions
namespace CompetitiveProgramming.CodeForces.ParityAlternatedDeletions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<long> evenNumbers = new List<long>();
        List<long> oddNumbers = new List<long>();
        
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        foreach (long number in numbers)
        {
            if (number % 2 == 0) evenNumbers.Add(number);
            else oddNumbers.Add(number);
        }
        
        evenNumbers.Sort();
        oddNumbers.Sort();
        long sum = 0;
        
        if (evenNumbers.Count > oddNumbers.Count)
        {
            int elementsToSkip = oddNumbers.Count + 1;
            for (int i = 0; i < evenNumbers.Count - elementsToSkip; i++)
            {
                sum += evenNumbers[i];
            }
        }
        else
        {
            int elementsToSkip = evenNumbers.Count + 1;
            for (int i = 0; i < oddNumbers.Count - elementsToSkip; i++)
            {
                sum += oddNumbers[i];
            }
        }
        
        Console.WriteLine(sum);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Parity Alternated Deletions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}