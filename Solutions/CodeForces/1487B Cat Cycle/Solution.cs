// Cat Cycle
namespace CompetitiveProgramming.CodeForces.CatCycle;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            
            k--;
            if (n % 2 == 1)
            {
                k += k / (n / 2);
            }
            
            Console.WriteLine(1 + (k % n));
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
        StyleHelper.Title("Cat Cycle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}