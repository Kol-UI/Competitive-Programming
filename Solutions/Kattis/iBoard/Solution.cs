// iBoard
namespace CompetitiveProgramming.Kattis.iBoard;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static (int, int) Write(int code, (int, int) state)
    {
        int a = state.Item1;
        int b = state.Item2;

        for (int i = 0; i < 7; i++)
        {
            if ((code & (1 << i)) != 0)
                b = 1 - b;
            else
                a = 1 - a;
        }

        return (a, b);
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            (int a, int b) state = (0, 0);

            foreach (char c in line)
            {
                state = Write((int)c, state);
            }

            Console.WriteLine(state == (0, 0) ? "free" : "trapped");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("iBoard");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}