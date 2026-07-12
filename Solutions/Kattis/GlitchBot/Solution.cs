// GlitchBot
namespace CompetitiveProgramming.Kattis.GlitchBot;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static string Other(string original)
    {
        if (original == "Left") return "Right";
        if (original == "Right") return "Forward";
        return "Left";
    }

    static string Other2(string original)
    {
        if (original == "Left") return "Forward";
        if (original == "Right") return "Left";
        return "Right";
    }

    static int Turn(int dir, string direction)
    {
        if (direction == "Left") dir--;
        if (direction == "Right") dir++;
        if (dir < 0) dir += 4;
        if (dir > 3) dir -= 4;
        return dir;
    }

    static void Move(ref int x, ref int y, ref int dir, string direction)
    {
        if (direction == "Forward")
        {
            if (dir == 0) y++;
            else if (dir == 1) x++;
            else if (dir == 2) y--;
            else if (dir == 3) x--;
        }
        else
        {
            dir = Turn(dir, direction);
        }
    }

    static bool Process(int targetX, int targetY, List<string> moves)
    {
        int currX = 0, currY = 0, dir = 0;
        foreach (string m in moves)
        {
            Move(ref currX, ref currY, ref dir, m);
        }
        return currX == targetX && currY == targetY;
    }

    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int endX = int.Parse(firstLine[0]);
        int endY = int.Parse(firstLine[1]);

        int n = int.Parse(Console.ReadLine());
        List<string> moves = new List<string>();

        for (int i = 0; i < n; i++)
        {
            moves.Add(Console.ReadLine());
        }

        for (int i = 0; i < moves.Count; i++)
        {
            string original = moves[i];

            moves[i] = Other(original);
            if (Process(endX, endY, moves))
            {
                Console.WriteLine($"{i + 1} {moves[i]}");
                return;
            }

            moves[i] = Other2(original);
            if (Process(endX, endY, moves))
            {
                Console.WriteLine($"{i + 1} {moves[i]}");
                return;
            }

            moves[i] = original;
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
        StyleHelper.Title("GlitchBot");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}