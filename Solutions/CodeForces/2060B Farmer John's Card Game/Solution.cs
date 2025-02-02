// Farmer John's Card Game
namespace CompetitiveProgramming.CodeForces.FarmerJohnsCardGame;
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
            int[] nm = ReadInts();
            int n = nm[0], m = nm[1];
            int[][] cards = new int[n][];
            
            for (int j = 0; j < n; j++)
            {
                cards[j] = ReadInts();
            }
            
            results.Add(Solve(cards));
        }
        
        PrintResults(results);
    }

    private static string Solve(int[][] cards)
    {
        foreach (var c in cards)
        {
            Array.Sort(c);
        }
        
        return cards.All(c => Enumerable.Range(0, c.Length - 1).All(i => c[i + 1] - c[i] == cards.Length))
            ? string.Join(" ", Enumerable.Range(0, cards.Length).OrderBy(i => cards[i][0]).Select(x => (x + 1).ToString()))
            : "-1";
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
        StyleHelper.Title("Farmer John's Card Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}