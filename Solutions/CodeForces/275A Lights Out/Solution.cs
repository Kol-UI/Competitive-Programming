// Lights Out
namespace CompetitiveProgramming.CodeForces.LightsOut;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    private const int SIZE = 3;
    private static readonly int[] R_OFFSETS = { 0, -1, 0, 1, 0 };
    private static readonly int[] C_OFFSETS = { 0, 0, 1, 0, -1 };

    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int[][] pressNums = new int[SIZE][];
        for (int i = 0; i < SIZE; i++)
        {
            pressNums[i] = ReadInts();
        }
        Console.Write(solve(pressNums));
    }

    private static string solve(int[][] pressNums)
    {
        bool[][] lights = Enumerable.Range(0, SIZE).Select(_ => Enumerable.Repeat(true, SIZE).ToArray()).ToArray();

        for (int r = 0; r < SIZE; r++)
        {
            for (int c = 0; c < SIZE; c++)
            {
                if (pressNums[r][c] % 2 != 0)
                {
                    press(lights, r, c);
                }
            }
        }

        StringBuilder result = new StringBuilder();
        for (int r = 0; r < SIZE; r++)
        {
            for (int c = 0; c < SIZE; c++)
            {
                result.Append(lights[r][c] ? '1' : '0');
            }
            result.Append('\n');
        }
        return result.ToString();
    }

    private static void press(bool[][] lights, int r, int c)
    {
        for (int i = 0; i < R_OFFSETS.Length; i++)
        {
            int adjR = r + R_OFFSETS[i];
            int adjC = c + C_OFFSETS[i];

            if (adjR >= 0 && adjR < SIZE && adjC >= 0 && adjC < SIZE)
            {
                lights[adjR][adjC] = !lights[adjR][adjC];
            }
        }
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
    private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    private static void PrintDouble(double value, int decimals) => Console.WriteLine(value.ToString($"F{decimals}"));
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lights Out");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}