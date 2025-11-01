// Only One Digit
namespace CompetitiveProgramming.CodeForces.OnlyOneDigit;
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
            long x = long.Parse(Console.ReadLine());
            int minDigit = 9;
            
            while (x > 0)
            {
                int digit = (int)(x % 10);
                minDigit = Math.Min(minDigit, digit);
                x /= 10;
            }
            
            Console.WriteLine(minDigit);
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
        StyleHelper.Title("Only One Digit");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}