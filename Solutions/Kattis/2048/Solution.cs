// 2048
namespace CompetitiveProgramming.Kattis.TwoZeroFourEight;
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
    static List<List<int>> board = new List<List<int>>();

    static List<int> Swipe(List<int> v)
    {
        List<int> v2 = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            if (v[i] != 0) v2.Add(v[i]);
        }
        v2.Add(0);

        for (int i = 0; i < v2.Count - 1; i++)
        {
            if (v2[i] == v2[i + 1])
            {
                v2[i] *= 2;
                v2[i + 1] = 0;
            }
        }

        List<int> v3 = new List<int>();
        for (int i = 0; i < v2.Count; i++)
        {
            if (v2[i] != 0) v3.Add(v2[i]);
        }

        int blanks = 4 - v3.Count;
        for (int i = 0; i < blanks; i++) v3.Add(0);

        return v3;
    }

    static void Main()
    {
        board = new List<List<int>>();
        for (int i = 0; i < 4; i++)
        {
            board.Add(new List<int>());
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < 4; j++)
            {
                board[i].Add(int.Parse(input[j]));
            }
        }

        int dir = int.Parse(Console.ReadLine());

        if (dir == 0)
        {
            for (int i = 0; i < 4; i++)
            {
                board[i] = Swipe(board[i]);
            }
        }
        if (dir == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                List<int> v = new List<int>
                {
                    board[0][i],
                    board[1][i],
                    board[2][i],
                    board[3][i]
                };
                v = Swipe(v);
                board[0][i] = v[0];
                board[1][i] = v[1];
                board[2][i] = v[2];
                board[3][i] = v[3];
            }
        }
        if (dir == 2)
        {
            for (int i = 0; i < 4; i++)
            {
                board[i].Reverse();
                board[i] = Swipe(board[i]);
                board[i].Reverse();
            }
        }
        if (dir == 3)
        {
            for (int i = 0; i < 4; i++)
            {
                List<int> v = new List<int>
                {
                    board[3][i],
                    board[2][i],
                    board[1][i],
                    board[0][i]
                };
                v = Swipe(v);
                board[0][i] = v[3];
                board[1][i] = v[2];
                board[2][i] = v[1];
                board[3][i] = v[0];
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{board[i][j]} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("2048");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}