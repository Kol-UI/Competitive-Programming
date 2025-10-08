// The Picky Cat
namespace CompetitiveProgramming.CodeForces.ThePickyCat;
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
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long x = Math.Abs(numbers[0]);
            int count = 0;
            
            for (int i = 1; i < n; i++)
            {
                long y = Math.Abs(numbers[i]);
                if (y >= x) count++;
            }
            
            Console.WriteLine(count >= (n - 1) / 2 ? "YES" : "NO");
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
        StyleHelper.Title("The Picky Cat");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}