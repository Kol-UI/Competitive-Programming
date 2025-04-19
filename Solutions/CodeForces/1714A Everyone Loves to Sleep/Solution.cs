// Everyone Loves to Sleep
namespace CompetitiveProgramming.CodeForces.EveryoneLovestoSleep;
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
            var input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            int m = int.Parse(input[2]);

            int tot = 100000;
            for (int i = 0; i < n; i++)
            {
                var time = Console.ReadLine()!.Split();
                int hh = int.Parse(time[0]);
                int mm = int.Parse(time[1]);

                int cnt = 0;
                for (int x = h, y = m; x != hh || y != mm;)
                {
                    y++;
                    x += (y == 60) ? 1 : 0;
                    x %= 24;
                    y %= 60;
                    cnt++;
                }

                tot = Math.Min(tot, cnt);
            }

            Console.WriteLine($"{tot / 60} {tot % 60}");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Everyone Loves to Sleep");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}