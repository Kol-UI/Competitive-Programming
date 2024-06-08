// Matrix Exploration



using System;
using System.Collections.Generic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CSAcademy.MatrixExploration;


class Solution
{
    //static void Main(string[] args)
    static void Problem()
    {
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int k = int.Parse(input[2]);

        char[][] a = new char[n][];
        
        for (int i = 0; i < n; i++)
        {
            a[i] = Console.ReadLine()!.ToCharArray();
        }

        int[] x = new int[k];
        int[] y = new int[k];
        
        for (int i = 0; i < k; i++)
        {
            input = Console.ReadLine()!.Split();
            x[i] = int.Parse(input[0]) - 1;
            y[i] = int.Parse(input[1]) - 1;
        }

        Queue<(int, int)> q = new Queue<(int, int)>();
        int[][] di = new int[n][];
        
        for (int i = 0; i < n; i++)
        {
            di[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                di[i][j] = -1;
            }
        }

        for (int i = 0; i < k; i++)
        {
            di[x[i]][y[i]] = 0;
            q.Enqueue((x[i], y[i]));
        }

        int[][] directions =
        {
            new int[] { -1, 0 },
            new int[] { 0, -1 },
            new int[] { 1, 0 },
            new int[] { 0, 1 }
        };
        
        while (q.Count > 0)
        {
            (int s, int t) = q.Dequeue();
            foreach (var dir in directions)
            {
                int dx = dir[0];
                int dy = dir[1];
                int nx = s + dx;
                int ny = t + dy;
                if (nx >= 0 && nx < n && ny >= 0 && ny < m && a[nx][ny] == '.')
                {
                    if (di[nx][ny] == -1)
                    {
                        di[nx][ny] = di[s][t] + 1;
                        q.Enqueue((nx, ny));
                    }
                }
            }
        }

        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i][j] == '.')
                {
                    answer += di[i][j];
                }
            }
        }

        Console.WriteLine(answer);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Matrix Exploration");
        ResultTester.SpecialTestCase(ProblemOrigin.CSAcademy, ProblemCategory.EasyCSA);
    }
}