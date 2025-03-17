// Kana and Dragon Quest game
namespace CompetitiveProgramming.CodeForces.KanaandDragonQuestgame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int x = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int m = int.Parse(input[2]);

            int zz = n + m;
            bool ok = false;

            for (int i = 1; i <= zz; i++)
            {
                if (x / 2 + 10 < x - 10 && n > 0)
                {
                    x = x / 2 + 10;
                    n--;
                }
                else if (x / 2 + 10 >= x - 10 && n > 0 && x > 20)
                {
                    x = x / 2 + 10;
                    n--;
                }
                else if (m > 0)
                {
                    x -= 10;
                    m--;
                }

                if (x <= 0)
                {
                    ok = true;
                    break;
                }
            }

            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kana and Dragon Quest game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}