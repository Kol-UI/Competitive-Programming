// Mocha and Hiking
namespace CompetitiveProgramming.CodeForces.MochaandHiking;
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
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] a = new int[n];
            long move = -1;
            
            for (long p = 0; p < n; p++)
            {
                a[p] = int.Parse(input[p]);
                if (p == 0 && a[0] == 1) move = -1;
                else if (p == n - 1 && a[n - 1] == 0) move = n - 1;
                else if (p > 0 && a[p - 1] == 0 && a[p] == 1) move = p - 1;
            }
            
            if (move < 0)
            {
                Console.Write($"{n + 1} ");
            }
            
            for (long p = 0; p < n; p++)
            {
                Console.Write($"{p + 1} ");
                if (move == p)
                {
                    Console.Write($"{n + 1} ");
                }
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
        StyleHelper.Title("Mocha and Hiking");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}