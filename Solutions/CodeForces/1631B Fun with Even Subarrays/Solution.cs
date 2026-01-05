// Fun with Even Subarrays
namespace CompetitiveProgramming.CodeForces.FunwithEvenSubarrays;
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
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Reverse(numbers);
            
            long index = 1;
            long count = 0;
            
            while (index < n)
            {
                if (numbers[index] == numbers[0])
                {
                    index++;
                }
                else
                {
                    count++;
                    index *= 2;
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
        StyleHelper.Title("Fun with Even Subarrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}