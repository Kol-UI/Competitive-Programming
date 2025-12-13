// 378QAQ and Mocha's Array
namespace CompetitiveProgramming.CodeForces.QAQandMochasArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long min1 = numbers.Min();
            long min2 = 1000000007;
            
            foreach (long number in numbers)
            {
                if (number % min1 != 0 && number < min2) min2 = number;
            }
            
            bool possible = true;
            foreach (long number in numbers)
            {
                if (number % min1 != 0 && number % min2 != 0)
                {
                    possible = false;
                    break;
                }
            }
            
            Console.WriteLine(possible ? "Yes" : "No");
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
        StyleHelper.Title("378QAQ and Mocha's Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}