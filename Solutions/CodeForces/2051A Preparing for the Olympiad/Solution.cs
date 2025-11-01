// Preparing for the Olympiad
namespace CompetitiveProgramming.CodeForces.PreparingfortheOlympiad;
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
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long result = a[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                long diff = a[i] - b[i + 1];
                if (diff > 0) result += diff;
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
        StyleHelper.Title("Preparing for the Olympiad");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}