// Subtract Min Sort
namespace CompetitiveProgramming.CodeForces.SubtractMinSort;
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
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            for (int i = 1; i < n; i++)
            {
                long min = Math.Min(numbers[i - 1], numbers[i]);
                numbers[i - 1] -= min;
                numbers[i] -= min;
            }
            
            bool valid = true;
            for (int i = 1; i < n && valid; i++)
            {
                if (numbers[i - 1] > numbers[i]) valid = false;
            }
            
            Console.WriteLine(valid ? "YES" : "NO");
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
        StyleHelper.Title("Subtract Min Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}