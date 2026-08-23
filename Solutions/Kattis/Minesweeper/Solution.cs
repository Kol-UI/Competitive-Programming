// Minesweeper
namespace CompetitiveProgramming.Kattis.Minesweeper;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);
        int k = int.Parse(firstLine[2]);

        char[][] grid = new char[n][];
        for (int i = 0; i < n; i++)
        {
            grid[i] = new char[m];
            for (int j = 0; j < m; j++)
                grid[i][j] = '.';
        }

        for (int i = 0; i < k; i++)
        {
            string[] input = Console.ReadLine().Split();
            int r = int.Parse(input[0]) - 1;
            int c = int.Parse(input[1]) - 1;
            grid[r][c] = '*';
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(grid[i]));
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minesweeper");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}