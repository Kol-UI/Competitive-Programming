// Minimum LCM
namespace CompetitiveProgramming.CodeForces.MinimumLCM;
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
            long n = long.Parse(Console.ReadLine());
            long divisor = n;
            
            for (long p = 2; p * p <= n; p++)
            {
                if (n % p == 0)
                {
                    divisor = p;
                    break;
                }
            }
            
            long quotient = n / divisor;
            long remainder = (divisor - 1) * quotient;
            Console.WriteLine($"{quotient} {remainder}");
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
        StyleHelper.Title("Minimum LCM");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}