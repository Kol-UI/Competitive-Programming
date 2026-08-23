// Parket
namespace CompetitiveProgramming.Kattis.Parket;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine()!.Split();
        int r = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        for (int l = 1; l < r - 1; l++)
        {
            int w = r - 2 * l + 4;
            if ((w & 1) != 0)
            {
                continue;
            }
            w >>= 1;
            if ((w - 2) * (l - 2) == b)
            {
                Console.WriteLine($"{Math.Max(w, l)} {Math.Min(w, l)}");
                break;
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Parket");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}