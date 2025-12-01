// Numbers Box
namespace CompetitiveProgramming.CodeForces.NumbersBox;
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
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] dimensions = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long rows = dimensions[0];
            long cols = dimensions[1];
            
            long total = 0;
            long negativeCount = 0;
            long minAbsolute = 101;
            
            for (long row = 0; row < rows; row++)
            {
                long[] rowValues = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                foreach (long value in rowValues)
                {
                    long absoluteValue = Math.Abs(value);
                    if (value < 0) negativeCount++;
                    minAbsolute = Math.Min(minAbsolute, absoluteValue);
                    total += absoluteValue;
                }
            }
            
            if (negativeCount % 2 == 1) total -= 2 * minAbsolute;
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
        StyleHelper.Title("Numbers Box");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}