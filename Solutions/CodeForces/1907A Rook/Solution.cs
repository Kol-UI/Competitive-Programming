// Rook

namespace CompetitiveProgramming.CodeForces.Rook;
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
            string square = ReadLn();
            results.Add(Solve(square));
        }
        
        PrintResults(results);
    }

    private static string Solve(string square)
    {
        var moves = Enumerable
            .Range('1', 8)
            .Where(c => c != square[1])
            .Select(c => $"{square[0]}{(char)c}")
            .Concat(
                Enumerable.Range('a', 8)
                .Where(c => c != square[0])
                .Select(c => $"{(char)c}{square[1]}")
            );

        return string.Join("\n", moves);
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
        StyleHelper.Title("Rook");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}