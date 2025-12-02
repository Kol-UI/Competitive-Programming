// Optimal Reduction
namespace CompetitiveProgramming.CodeForces.OptimalReduction;
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
            
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i - 1] <= numbers[i]) count++;
                else break;
            }
            
            for (int i = n - 1; i > 0; i--)
            {
                if (numbers[i - 1] >= numbers[i]) count++;
                else break;
            }
            
            Console.WriteLine(count >= n - 1 ? "YES" : "NO");
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
        StyleHelper.Title("Optimal Reduction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}