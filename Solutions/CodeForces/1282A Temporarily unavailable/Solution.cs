// Temporarily unavailable
namespace CompetitiveProgramming.CodeForces.Temporarilyunavailable;
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
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = numbers[0];
            long b = numbers[1];
            long c = numbers[2];
            long d = numbers[3];
            
            if (a > b)
            {
                long temp = a;
                a = b;
                b = temp;
            }
            
            long left = c - d;
            long right = c + d;
            long overlap = 0;
            
            if (right <= a || b <= left)
            {
                overlap = 0;
            }
            else if (left <= a && b <= right)
            {
                overlap = b - a;
            }
            else if (a <= left && right <= b)
            {
                overlap = right - left;
            }
            else
            {
                long min = Math.Max(a, left);
                long max = Math.Min(b, right);
                overlap = max - min;
            }
            
            long result = (b - a) - overlap;
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
        StyleHelper.Title("Temporarily unavailable");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}