// Find and Replace

namespace CompetitiveProgramming.CodeForces.FindandReplace;
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
            results.Add(Solve(s) ? "YES" : "NO");
        }

        PrintResults(results);
    }

    private static bool Solve(string s)
    {
        Dictionary<char, List<int>> letterToIndices = new Dictionary<char, List<int>>();
        for (int i = 0; i < s.Length; i++)
        {
            char letter = s[i];
            if (!letterToIndices.ContainsKey(letter))
            {
                letterToIndices[letter] = new List<int>();
            }
            letterToIndices[letter].Add(i);
        }

        return letterToIndices.Values.All(indices => indices.Select(x => x % 2).Distinct().Count() == 1);
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
        StyleHelper.Title("Find and Replace");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}