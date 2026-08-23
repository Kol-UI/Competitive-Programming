// Jury Jeopardy
namespace CompetitiveProgramming.Kattis.JuryJeopardy;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static (int x, int y) Adv((int x, int y) p, (int x, int y) dr)
    {
        return (p.x + dr.x, p.y + dr.y);
    }

    static void Main()
    {
        (int x, int y)[] dirs = new (int, int)[]
        {
            (0, 1),
            (1, 0),
            (0, -1),
            (-1, 0)
        };

        Dictionary<char, int> delta = new Dictionary<char, int>
        {
            ['F'] = 0,
            ['R'] = 1,
            ['B'] = 2,
            ['L'] = 3
        };

        int testcases = int.Parse(Console.ReadLine()!);
        Console.WriteLine(testcases);

        for (int t = 0; t < testcases; t++)
        {
            (int x, int y) crdr = (0, 1);
            string s = Console.ReadLine()!;
            (int x, int y) pos = (0, 0);

            HashSet<(int x, int y)> inside = new HashSet<(int x, int y)>();
            inside.Add(pos);

            foreach (char c in s)
            {
                int currentIndex = Array.IndexOf(dirs, crdr);
                crdr = dirs[(currentIndex + delta[c]) % 4];
                pos = Adv(pos, crdr);
                inside.Add(pos);
            }

            int mini = inside.Min(p => p.x);
            int minj = inside.Min(p => p.y);
            int maxi = inside.Max(p => p.x);
            int maxj = inside.Max(p => p.y);

            int w = maxj + 2;
            int h = maxi - mini + 3;

            char[][] grid = new char[h][];
            for (int r = 0; r < h; r++)
            {
                grid[r] = new string('#', w).ToCharArray();
            }

            Console.WriteLine($"{h} {w}");

            foreach (var (i, j) in inside)
            {
                grid[i - mini + 1][j - minj] = '.';
            }

            foreach (var row in grid)
            {
                Console.WriteLine(new string(row));
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jury Jeopardy");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}