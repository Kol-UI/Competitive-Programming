// Luke is a Foodie
namespace CompetitiveProgramming.CodeForces.LukeisaFoodie;
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
            long x = input[1];
            
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long count = 0;
            long low = 0;
            long high = 2000000007;
            
            foreach (long number in numbers)
            {
                long left = number - x;
                long right = number + x;
                low = Math.Max(low, left);
                high = Math.Min(high, right);
                if (low > high)
                {
                    count++;
                    low = left;
                    high = right;
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
        StyleHelper.Title("Luke is a Foodie");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}