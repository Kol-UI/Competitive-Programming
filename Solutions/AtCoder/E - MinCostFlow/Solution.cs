// MinCostFlow

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.AtCoder.EMinCostFlow
{
    class Solution
    {
        public static void MinCostFlowMain()
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            int[][] grid = new int[N][];
            int maxSum = 0;
            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine()!.Split();
                grid[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    grid[i][j] = int.Parse(row[j]);
                    maxSum += grid[i][j];
                }
            }

            char[][] chosen = new char[N][];
            for (int i = 0; i < N; i++)
            {
                chosen[i] = new char[N];
                for (int j = 0; j < N; j++)
                {
                    chosen[i][j] = '.';
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        chosen[i][j] = 'X';
                        maxSum -= grid[i][j];
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(new string(chosen[i]));
            }
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost Flow");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC);
        }
    }
}