// No Casino in the Mountains
namespace CompetitiveProgramming.CodeForces.NoCasinointheMountains;
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
            long k = input[1];
            
            bool blocked = false;
            long zeros = 0;
            long count = 0;
            
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == 1 || blocked)
                {
                    blocked = false;
                    zeros = 0;
                    continue;
                }
                
                zeros++;
                if (zeros >= k)
                {
                    count++;
                    zeros = 0;
                    blocked = true;
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
        StyleHelper.Title("No Casino in the Mountains");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}