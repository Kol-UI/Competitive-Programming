// Flipping Game
namespace CompetitiveProgramming.CodeForces.FlippingGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int cnt = 0;
        int mx = 0;
        int res = 0;
        string[] input = Console.ReadLine()!.Split();
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(input[i]);
            if ((a & 1) == 1)
            {
                res++;
                cnt--;
            }
            else
            {
                cnt++;
            }
            cnt = Math.Max(cnt, 0);
            mx = Math.Max(mx, cnt);
        }
        Console.WriteLine(mx > 0 ? mx + res : res - 1);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Flipping Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}