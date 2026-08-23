// Andrew and Stones
namespace CompetitiveProgramming.CodeForces.AndrewandStones;
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
            string[] inputs = Console.ReadLine().Split();
            bool ones = true;
            bool threeodd = false;
            long cnt = 0;
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(inputs[p]);
                if (p == 0 || p == n - 1)
                {
                    continue;
                }
                if (n == 3 && p == 1)
                {
                    threeodd = x % 2 == 1;
                }
                if (x > 1)
                {
                    ones = false;
                }
                cnt += (x + 1) / 2;
            }

            bool impossible = ones || threeodd;
            Console.WriteLine(impossible ? "-1" : cnt.ToString());
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
        StyleHelper.Title("Andrew and Stones");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}