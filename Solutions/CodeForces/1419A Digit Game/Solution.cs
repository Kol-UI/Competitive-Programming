// Digit Game
namespace CompetitiveProgramming.CodeForces.DigitGame;
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
            string s = Console.ReadLine()!;
            bool turn = n % 2 == 0;
            bool win = false;
            for (long p = turn ? 1 : 0; !win && p < s.Length; p += 2)
            {
                win |= (s[(int)p] % 2 == (turn ? 0 : 1));
            }
            Console.WriteLine(2 - (turn ^ win ? 1 : 0));
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
        StyleHelper.Title("Digit Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}