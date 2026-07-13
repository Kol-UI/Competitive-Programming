// Misa
namespace CompetitiveProgramming.Kattis.Misa;
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

        char[][] grid = new char[n][];
        for (int i = 0; i < n; i++)
        {
            grid[i] = Console.ReadLine().ToCharArray();
        }

        int sm = 0;
        int mx = 0;

        int[] di = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dj = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int cur = 0;

                for (int d = 0; d < 8; d++)
                {
                    int ni = i + di[d];
                    int nj = j + dj[d];

                    if (ni < 0 || ni >= n || nj < 0 || nj >= m)
                        continue;

                    if (grid[ni][nj] == 'o')
                        cur++;
                }

                if (grid[i][j] == 'o')
                    sm += cur;
                else
                    mx = Math.Max(mx, cur);
            }
        }

        sm /= 2;
        sm += mx;
        Console.WriteLine(sm);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Misa");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}