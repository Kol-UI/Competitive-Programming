// Array Cancellation
namespace CompetitiveProgramming.CodeForces.ArrayCancellation;
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
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long available = 0;
            long count = 0;
            
            foreach (long number in numbers)
            {
                if (number > 0)
                {
                    available += number;
                }
                else if (number < 0)
                {
                    if (number + available > 0)
                    {
                        available += number;
                    }
                    else
                    {
                        long remaining = number + available;
                        count -= remaining;
                        available = 0;
                    }
                }
            }
            
            Console.WriteLine(count);
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
        StyleHelper.Title("Array Cancellation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}