// Turtle Master
namespace CompetitiveProgramming.Kattis.TurtleMaster;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Bug()
    {
        Console.WriteLine("Bug!");
        Environment.Exit(0);
    }

    static void Main()
    {
        char[][] grid = new char[8][];
        for (int i = 0; i < 8; i++)
        {
            grid[i] = Console.ReadLine().ToCharArray();
        }

        int r = 7;
        int c = 0;
        int dr = 0;
        int dc = 1;

        grid[r][c] = '.';

        string moves = Console.ReadLine();

        foreach (char ch in moves)
        {
            if (ch == 'F')
            {
                int nr = r + dr;
                int nc = c + dc;

                if (nr < 0 || nr >= 8 || nc < 0 || nc >= 8)
                    Bug();

                if (grid[nr][nc] == 'I' || grid[nr][nc] == 'C')
                    Bug();

                r = nr;
                c = nc;
            }
            else if (ch == 'R')
            {
                int temp = dr;
                dr = dc;
                dc = -temp;
            }
            else if (ch == 'L')
            {
                int temp = dr;
                dr = -dc;
                dc = temp;
            }
            else
            {
                int nr = r + dr;
                int nc = c + dc;

                if (nr < 0 || nr >= 8 || nc < 0 || nc >= 8)
                    Bug();

                if (grid[nr][nc] != 'I')
                    Bug();

                grid[nr][nc] = '.';
            }
        }

        if (grid[r][c] != 'D')
            Bug();

        Console.WriteLine("Diamond!");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Turtle Master");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}