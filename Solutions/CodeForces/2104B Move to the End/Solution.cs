// Move to the End
namespace CompetitiveProgramming.CodeForces.MovetotheEnd;
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
            
            long[] prefixMax = new long[n];
            long[] suffixSum = new long[n];
            
            prefixMax[0] = numbers[0];
            for (int i = 1; i < n; i++) prefixMax[i] = Math.Max(prefixMax[i - 1], numbers[i]);
            
            suffixSum[n - 1] = numbers[n - 1];
            for (int i = n - 2; i >= 0; i--) suffixSum[i] = suffixSum[i + 1] + numbers[i];
            
            for (int i = n - 1; i >= 0; i--)
            {
                long result = prefixMax[i] + (i + 1 < n ? suffixSum[i + 1] : 0);
                Console.Write(result + " ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("Move to the End");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}