// Espresso Bucks
namespace CompetitiveProgramming.Kattis.EspressoBucks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] nm = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        char[][] grid = new char[n][];
        for (int i = 0; i < n; i++)
        {
            grid[i] = Console.ReadLine().ToCharArray();
        }

        bool HasNei(int i, int j)
        {
            int[] di = { -1, 1, 0, 0 };
            int[] dj = { 0, 0, -1, 1 };

            for (int k = 0; k < 4; k++)
            {
                int ni = i + di[k];
                int nj = j + dj[k];

                if (ni < 0 || ni >= n || nj < 0 || nj >= m)
                    continue;

                if (grid[ni][nj] == 'E')
                    return true;
            }
            return false;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] != '.')
                    continue;

                if (HasNei(i, j))
                    continue;

                grid[i][j] = 'E';
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(grid[i]));
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Espresso Bucks");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}