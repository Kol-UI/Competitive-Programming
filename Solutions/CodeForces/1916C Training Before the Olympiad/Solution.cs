// Training Before the Olympiad
namespace CompetitiveProgramming.CodeForces.TrainingBeforetheOlympiad;
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
            
            long cs = 0;
            long cnt = 0;
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                cs += x;
                if (x % 2 == 1) cnt++;
                
                long ans = cs;
                if (cnt % 3 == 0 || cnt % 3 == 2)
                {
                    ans -= cnt / 3;
                }
                else if (cnt % 3 == 1 && p > 0)
                {
                    ans -= (cnt / 3) + 1;
                }
                
                Console.Write($"{ans} ");
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
        StyleHelper.Title("Training Before the Olympiad");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}