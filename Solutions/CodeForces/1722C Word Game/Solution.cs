// Word Game

namespace CompetitiveProgramming.CodeForces.WordGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private static readonly Dictionary<int, int> COUNT_TO_POINT = new()
    {
        {1, 3}, {2, 1}, {3, 0}
    };

    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<string> results = new();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            int n = ReadInt();
            string[][] words = new string[3][];
            for (int j = 0; j < 3; j++)
            {
                words[j] = ReadStrings();
            }
            results.Add(Solve(words));
        }

        PrintResults(results);
    }

    private static string Solve(string[][] words)
    {
        Dictionary<string, int> wordToCount = new();
        foreach (var group in words)
        {
            foreach (var word in group)
            {
                wordToCount[word] = wordToCount.GetValueOrDefault(word, 0) + 1;
            }
        }

        return string.Join(" ", words.Select(group => group.Sum(word => COUNT_TO_POINT[wordToCount[word]])));
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Word Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}