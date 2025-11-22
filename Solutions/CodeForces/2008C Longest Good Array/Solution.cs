// Longest Good Array
namespace CompetitiveProgramming.CodeForces.LongestGoodArray;
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
            long a = input[0];
            long b = input[1];
            
            long distance = b - a;
            long left = 1;
            long right = distance + 7;
            long result = 1;
            
            while (left <= right)
            {
                long mid = (left + right) / 2;
                long testValue = mid * (mid - 1) / 2;
                
                if (testValue <= distance)
                {
                    result = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Longest Good Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}