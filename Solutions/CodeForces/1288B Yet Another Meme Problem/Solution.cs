// Yet Another Meme Problem
namespace CompetitiveProgramming.CodeForces.YetAnotherMemeProblem;
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
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);

            long b = 9;
            long cnt = 0;

            while (b <= B)
            {
                cnt += A;
                b = 10 * b + 9;
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Yet Another Meme Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}