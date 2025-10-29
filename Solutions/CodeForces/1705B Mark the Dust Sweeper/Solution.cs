// Mark the Dust Sweeper
namespace CompetitiveProgramming.CodeForces.MarktheDustSweeper;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long operations = 0;
            bool foundNonZero = false;
            
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > 0)
                {
                    foundNonZero = true;
                    operations += a[i];
                }
                else if (foundNonZero)
                {
                    operations++;
                }
            }
            
            Console.WriteLine(operations);
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
        StyleHelper.Title("Mark the Dust Sweeper");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}