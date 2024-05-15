// D - Maxflow
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.AtCoder.DMaxflow
{
    /*
    class Solution
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            string[] grid = new string[N];
            for (int i = 0; i < N; i++)
            {
                grid[i] = Console.ReadLine();
            }

            int maxTiles = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (grid[i][j] == '.' && (i + j) % 2 == 0)
                    {
                        maxTiles++;
                    }
                }
            }

            Console.WriteLine(maxTiles);

            char[][] configuration = new char[N][];
            for (int i = 0; i < N; i++)
            {
                configuration[i] = new char[M];
                for (int j = 0; j < M; j++)
                {
                    configuration[i][j] = (i + j) % 2 == 0 ? 'v' : '^';
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (grid[i][j] == '.')
                    {
                        Console.Write(configuration[i][j]);
                    }
                    else
                    {
                        Console.Write(grid[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
    */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("MaxFlow");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC);
        }
    }
}