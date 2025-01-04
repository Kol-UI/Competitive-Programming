// Symmetric Encoding

namespace CompetitiveProgramming.CodeForces.SymmetricEncoding;
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
            string b = ReadLn();

            results.Add(Solve(b));
        }

        PrintResults(results);
    }

    private static string Solve(string b)
    {
        string r = new string(b.Distinct().OrderBy(c => c).ToArray());

        var translation = r.Select((c, i) => new { Original = c, Translated = r[r.Length - 1 - i] })
                           .ToDictionary(x => x.Original, x => x.Translated);

        return new string(b.Select(c => translation[c]).ToArray());
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Symmetric Encoding");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}