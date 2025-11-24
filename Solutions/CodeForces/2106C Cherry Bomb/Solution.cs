// Cherry Bomb
namespace CompetitiveProgramming.CodeForces.CherryBomb;
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
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0];
            long k = input[1];
            
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long left = 0;
            long right = 2 * k;
            
            for (int i = 0; i < n; i++)
            {
                long currentLeft = a[i] + (b[i] < 0 ? 0 : b[i]);
                left = Math.Max(left, currentLeft);
                
                long currentRight = a[i] + (b[i] < 0 ? k : b[i]);
                right = Math.Min(right, currentRight);
            }
            
            long result = left <= right ? right - left + 1 : 0;
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
        StyleHelper.Title("Cherry Bomb");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}