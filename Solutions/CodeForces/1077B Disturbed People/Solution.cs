// Disturbed People
namespace CompetitiveProgramming.CodeForces.DisturbedPeople;
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
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        long count = 0;
        for (int i = 1; i < n - 1; i++)
        {
            if (numbers[i] == 1) continue;
            if (numbers[i - 1] == 1 && numbers[i + 1] == 1)
            {
                numbers[i + 1] = 0;
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Disturbed People");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}