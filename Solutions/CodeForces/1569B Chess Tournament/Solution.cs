// Chess Tournament

namespace CompetitiveProgramming.CodeForces.ChessTournament;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<string> results = new List<string>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            ReadInt();
            string s = ReadLn();
            results.Add(Solve(s));
        }

        PrintResults(results);
    }

    private static string Solve(string s)
    {
        int n = s.Length;
        int[] typeTwoPlayers = Enumerable.Range(0, n).Where(i => s[i] == '2').ToArray();
        if (typeTwoPlayers.Length == 1 || typeTwoPlayers.Length == 2)
        {
            return "NO";
        }

        char[,] matrix = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (i == j) ? 'X' : '=';
            }
        }

        for (int i = 0; i < typeTwoPlayers.Length; i++)
        {
            int player1 = typeTwoPlayers[i];
            int player2 = typeTwoPlayers[(i + 1) % typeTwoPlayers.Length];
            matrix[player1, player2] = '+';
            matrix[player2, player1] = '-';
        }

        return "YES\n" + string.Join("\n", Enumerable.Range(0, n).Select(i => new string(Enumerable.Range(0, n).Select(j => matrix[i, j]).ToArray())));
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
        StyleHelper.Title("Chess Tournament");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}