// Destruction of the Dandelion Fields
namespace CompetitiveProgramming.CodeForces.DestructionoftheDandelionFields;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            List<long> oddNumbers = new List<long>();
            long total = 0;
            
            foreach (long number in numbers)
            {
                if (number % 2 == 1) oddNumbers.Add(number);
                else total += number;
            }
            
            if (oddNumbers.Count == 0)
            {
                Console.WriteLine("0");
                continue;
            }
            
            oddNumbers.Sort();
            oddNumbers.Reverse();
            
            for (int i = 0; i < (oddNumbers.Count + 1) / 2; i++)
            {
                total += oddNumbers[i];
            }
            
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
        StyleHelper.Title("Destruction of the Dandelion Fields");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}