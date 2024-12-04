// Gifs Fixing
namespace CompetitiveProgramming.CodeForces.GifsFixing;

using System;
using System.Collections.Generic;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        try
        {
            int numberOfTestCases = ReadInt();
            List<long> results = new List<long>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                int[] a = ReadInts();
                int[] b = ReadInts();

                if (a.Length != n || b.Length != n)
                {
                    throw new InvalidOperationException("Length not n");
                }

                results.Add(Solve(a, b));
            }

            PrintResults(results);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }
    }

    private static long Solve(int[] a, int[] b)
    {
        if (a.Length == 0 || b.Length == 0)
        {
            throw new InvalidOperationException("Empty");
        }

        int minA = a.Min();
        int minB = b.Min();

        long totalMoves = 0;

        for (int i = 0; i < a.Length; i++)
        {
            int movesToFixA = a[i] - minA;
            int movesToFixB = b[i] - minB;
            totalMoves += Math.Max(movesToFixA, movesToFixB);
        }

        return totalMoves;
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Gifs Fixing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}