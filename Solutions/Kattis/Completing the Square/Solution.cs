// Completing the Square
namespace CompetitiveProgramming.Kattis.CompletingtheSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static int Dot((int, int) u, (int, int) v)
    {
        return u.Item1 * v.Item1 + u.Item2 * v.Item2;
    }

    static ((int, int), (int, int)) TransFrom((int, int) a, (int, int) b, (int, int) c)
    {
        return ((b.Item1 - a.Item1, b.Item2 - a.Item2), (c.Item1 - a.Item1, c.Item2 - a.Item2));
    }

    static void Main()
    {
        List<(int, int)> pos = new List<(int, int)>();
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            pos.Add((int.Parse(input[0]), int.Parse(input[1])));
        }

        for (int k = 0; k < 3; k++)
        {
            var t = TransFrom(pos[0], pos[1], pos[2]);
            if (Dot(t.Item1, t.Item2) == 0)
            {
                int x = pos[0].Item1 + t.Item1.Item1 + t.Item2.Item1;
                int y = pos[0].Item2 + t.Item1.Item2 + t.Item2.Item2;
                Console.WriteLine($"{x} {y}");
            }
            pos = new List<(int, int)> { pos[1], pos[2], pos[0] };
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Completing the Square");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}