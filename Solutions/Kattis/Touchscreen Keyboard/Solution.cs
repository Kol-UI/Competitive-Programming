// Touchscreen Keyboard
namespace CompetitiveProgramming.Kattis.TouchscreenKeyboard;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] keyb = {
            "qwertyuiop",
            "asdfghjkl ",
            "zxcvbnm   "
        };

        Dictionary<char, (int, int)> pos = new Dictionary<char, (int, int)>();

        for (int row = 0; row < keyb.Length; row++)
        {
            for (int col = 0; col < keyb[row].Length; col++)
            {
                char c = keyb[row][col];
                if (c != ' ')
                    pos[c] = (row, col);
            }
        }

        Dictionary<(char, char), int> dist = new Dictionary<(char, char), int>();
        List<char> alpha = new List<char>();
        for (int i = 0; i < 26; i++)
            alpha.Add((char)('a' + i));

        foreach (char a in alpha)
        {
            foreach (char b in alpha)
            {
                dist[(a, b)] = Math.Abs(pos[a].Item1 - pos[b].Item1) +
                               Math.Abs(pos[a].Item2 - pos[b].Item2);
            }
        }

        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            string s = input[0];
            int n = int.Parse(input[1]);

            List<string> ws = new List<string>();
            for (int j = 0; j < n; j++)
                ws.Add(Console.ReadLine());

            ws = ws.OrderBy(x => Wdist(s, x, dist)).ThenBy(x => x).ToList();

            foreach (string x in ws)
                Console.WriteLine($"{x} {Wdist(s, x, dist)}");
        }
    }

    static int Wdist(string x, string y, Dictionary<(char, char), int> dist)
    {
        int sum = 0;
        for (int i = 0; i < x.Length; i++)
            sum += dist[(x[i], y[i])];
        return sum;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Touchscreen Keyboard");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}